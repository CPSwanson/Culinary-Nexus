Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Text
Imports System.Collections.Generic

Public Class Proc
    Private Shared _id As Int32
    Private Shared _dtRecipes As New DataTable
    Private Shared _logged As Boolean = False
    Public Structure _image
        Private id_ As Int32
        Private image_ As Image

        Public Property ID() As Int32
            Get
                Return id_
            End Get
            Set(value As Int32)
                id_ = value
            End Set
        End Property

        Public Property Image() As Image
            Get
                Return image_
            End Get
            Set(value As Image)
                image_ = value
            End Set
        End Property
    End Structure

    Private Shared _Images As New List(Of _image)

#Region "Properties"
    Public Shared ReadOnly Property DTRecipes() As DataTable
        Get
            Return _dtRecipes
        End Get
    End Property

    Public ReadOnly Property Images As List(Of _image)
        Get
            Return _Images
        End Get
    End Property

    Public Shared Property Logged As Boolean
        Get
            Return _logged
        End Get
        Set(value As Boolean)
            _logged = value
        End Set
    End Property

    Public Shared Property ID As Int32
        Get
            Return _id
        End Get
        Set(value As Int32)
            _id = value
        End Set
    End Property
#End Region

    'Grabs image from list
    Public Function getImage(rID As Int32) As Image
        Dim rImage As Image = Nothing

        For Each image As _image In _Images
            If image.ID = rID Then
                rImage = image.Image
            End If
        Next

        Return rImage

    End Function

    'Grabs recipes from database
    Public Function loadData() As String
        Dim _dtImages As New DataTable

        Dim MYcon As New MySqlConnection("Server = cstnt.tstc.edu;Database = cpswanson;User id=cpswanson;password=1498787;Sslmode = none")
        Dim MScon As New SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787")

        Try
            Dim MYcmd As New MySqlCommand("Select * from cpswanson.recipes", MYcon)
            Dim _daRecipes As New MySqlDataAdapter
            _daRecipes.SelectCommand = MYcmd

            MYcon.Open()
            _dtRecipes.Clear()
            _daRecipes.Fill(_dtRecipes)
            MYcon.Close()

            'Pulls images from database
            Dim MScmd As New SqlCommand("Select * From cpswanson.stRImages", MScon)
            Dim _daImages As New SqlDataAdapter
            _daImages.SelectCommand = MScmd

            MScon.Open()
            _daImages.Fill(_dtImages)
            MScon.Close()

            'Stores images in a list
            For Each row As DataRow In _dtImages.Rows
                Dim temp As New _image
                temp.ID = Int32.Parse(row(0).ToString)
                Dim data() As Byte = row(1)
                Dim mStream As New IO.MemoryStream(data)
                temp.Image = Image.FromStream(mStream)
                mStream.Dispose()
                _Images.Add(temp)
            Next

            Return "Loaded"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    'Checks Database for user
    Public Function login(un As String, pw As String) As String
        Dim MYcon As New MySqlConnection("Server = cstnt.tstc.edu;Database = cpswanson;User id=cpswanson;password=1498787;Sslmode = none")
        Dim MYcmd As New MySqlCommand($"Select uID from cpswanson.users Where username = '{un}' And password = '{pw}'", MYcon)

        Try
            MYcon.Open()

            Dim reader As MySqlDataReader = MYcmd.ExecuteReader()

            If reader.HasRows = True Then
                reader.Dispose()
            Else
                Return "Fail"
            End If

            _id = Int32.Parse(MYcmd.ExecuteScalar().ToString)
            _logged = True

            MYcon.Close()
            Return "Success"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Registers new user
    Public Function newAccount(un As String, pw As String) As String
        Dim MYcon As New MySqlConnection("Server = cstnt.tstc.edu;Database = cpswanson;User id=cpswanson;password=1498787;Sslmode = none")
        Dim uID As Int32 = 200

        Try
            Dim MYcmd As New MySqlCommand($"Select uID from cpswanson.users Where username = '{un}'", MYcon)

            MYcon.Open()
            Dim reader As MySqlDataReader = MYcmd.ExecuteReader()
            If reader.HasRows = True Then 'Sees if there is already exists
                Return "An account with this username already exists."
            Else
                reader.Dispose()
            End If

            MYcmd = New MySqlCommand("Select Max(uID) From cpswanson.users", MYcon)

            If Not String.IsNullOrEmpty(MYcmd.ExecuteScalar.ToString) Then
                uID = Int32.Parse(MYcmd.ExecuteScalar.ToString) + 4
            End If

            MYcmd = New MySqlCommand($"Insert Into cpswanson.users(uID,username,password) Values({uID},'{un}','{pw}');", MYcon)
            MYcmd.ExecuteNonQuery()
            MYcon.Close()
            _id = uID

            Return "Registered"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    'Inserts new recipe into database
    Public Function upload(title As String, details As String, Ingredients As List(Of String), foodType As String, image As Image) As String
        Dim MYcon As New MySqlConnection("Server = cstnt.tstc.edu;Database = cpswanson;User id=cpswanson;password=1498787;Sslmode = none")
        Dim MScon As New SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787")

        Try
            Dim rID As Int32 = 100

            Dim MYcmd As New MySqlCommand("Select max(rID) from cpswanson.recipes", MYcon)

            MYcon.Open()
            If Not String.IsNullOrEmpty(MYcmd.ExecuteScalar.ToString) Then
                rID = Int32.Parse(MYcmd.ExecuteScalar.ToString) + 4
            End If

            MYcmd = New MySqlCommand($"Insert Into cpswanson.recipes(rID,uID,title,instructions,views,downloads, foodType) Values({rID},{_id},'{title}','{details}',0,0, '{foodType}');", MYcon)
            MYcmd.ExecuteNonQuery()

            'Bulk insert of ingredients"
            Dim cmd As New StringBuilder("Insert Into cpswanson.ingredients(rID,ingredient) Values")

            'Formats the list of ingredients into row inserts
            Dim rows As New List(Of String)
            For Each ing As String In Ingredients
                ing.Trim()
                MYcmd = New MySqlCommand($"Insert Into cpswanson.ingredients(rID,ingredient) Values({rID},'{ing}')", MYcon)
                MYcmd.ExecuteNonQuery()
            Next
            MYcon.Close()

            'Uploads image to database
            Dim mStream As New IO.MemoryStream
            image.Save(mStream, Imaging.ImageFormat.Png)
            Dim data() As Byte = mStream.ToArray
            mStream.Dispose()
            Dim MScmd As New SqlCommand($"Insert Into cpswanson.stRImages(rID,rImage) Values({rID},@image)", MScon)
            Dim param As New SqlParameter
            param = MScmd.Parameters.AddWithValue("@image", data)
            param.DbType = DbType.Binary
            MScon.Open()
            MScmd.ExecuteNonQuery()
            MScon.Close()

            Return "Uploaded"
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    'Deletes recipe from database
    Public Function deleteRecipe(rID As Int32) As String
        Dim MYcon As New MySqlConnection("Server = cstnt.tstc.edu;Database = cpswanson;User id=cpswanson;password=1498787;Sslmode = none")
        Dim MScon As New SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787")

        Dim MYcmd As New MySqlCommand($"Delete From cpswanson.recipes Where rID = {rID}", MYcon)
        Dim MScmd As New SqlCommand($"Delete From cpswanson.stRImages Where rID = {rID}", MScon)
        Try
            MYcon.Open()
            MYcmd.ExecuteNonQuery()
            MYcon.Close()

            MScon.Open()
            MScmd.ExecuteNonQuery()
            MScon.Close()

            Return "Deleted"

        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    'Gets selected recipe for crystal report
    Public Function getRec(rId As Int32) As DataSet
        Dim _dsRec As New DataSet("Recipe")

        Dim MYcon As New MySqlConnection("Server = cstnt.tstc.edu;Database = cpswanson;User id=cpswanson;password=1498787;Sslmode = none")
        Dim MYcmd As New MySqlCommand($"Select title, instructions, foodType from cpswanson.recipes Where rID = {rId}", MYcon)

        Try
            MYcon.Open()

            Dim _daRec As New MySqlDataAdapter
            _daRec.SelectCommand = MYcmd
            _daRec.Fill(_dsRec)

            MYcon.Close()
            Return _dsRec
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'Gets ingredients for selected recipe
    Public Function getIng(rID As Int32) As DataSet
        Dim _dsIngredients As New DataSet("Ingredients")

        Dim MYcon As New MySqlConnection("Server = cstnt.tstc.edu;Database = cpswanson;User id=cpswanson;password=1498787;Sslmode = none")
        Dim MYcmd As New MySqlCommand($"Select * from cpswanson.ingredients Where rID = {rID}", MYcon)

        Try
            MYcon.Open()

            Dim _daIng As New MySqlDataAdapter
            _daIng.SelectCommand = MYcmd
            _daIng.Fill(_dsIngredients)

            MYcon.Close()
            Return _dsIngredients
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'Gets recipes uploaded by user
    Public Function getMyRec() As DataSet
        Dim myRec As New DataSet("My Recipes")

        Dim MYcon As New MySqlConnection("Server = cstnt.tstc.edu;Database = cpswanson;User id=cpswanson;password=1498787;Sslmode = none")
        Dim MYcmd As New MySqlCommand($"Select * from cpswanson.Recipes Where uID = {_id}", MYcon)

        Dim daAdapter As New MySqlDataAdapter
        daAdapter.SelectCommand = MYcmd

        MYcon.Open()
        daAdapter.Fill(myRec)
        myRec.Tables(0).TableName = "Recipes"
        MYcon.Close()

        Return myRec
    End Function

    'Logs that a user has viewed the recipe
    Public Function viewed(rID As Int32) As String
        Dim MYcon As New MySqlConnection("Server = cstnt.tstc.edu;Database = cpswanson;User id=cpswanson;password=1498787;Sslmode = none")
        Dim MYcmd As New MySqlCommand($"Update cpswanson.recipes Set views = (views + 1) Where rID = {rID}", MYcon)

        Try
            MYcon.Open()
            MYcmd.ExecuteNonQuery()
            MYcon.Close()

            Return "Logged"
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    'Logs that a user has downloaded the recipe
    Public Function downloaded(rID As Int32) As String
        Dim MYcon As New MySqlConnection("Server = cstnt.tstc.edu;Database = cpswanson;User id=cpswanson;password=1498787;Sslmode = none")
        Dim MYcmd As New MySqlCommand($"Update cpswanson.recipes Set downloads = (downloads + 1) Where rID = {rID}", MYcon)

        Try
            MYcon.Open()
            MYcmd.ExecuteNonQuery()
            MYcon.Close()

            Return "Logged"
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function
End Class
