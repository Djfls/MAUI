<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(199, 166)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Private Sub FormGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DataGridView1.DataSource = CreateDataSet()

        Dim cst As New CDataTable()

        Me.DataGridView1.DataSource = cst.SwapXY(Me.DataGridView1.DataSource, "年度")

    End Sub

    Private Sub FormGrid_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Close()
    End Sub

    Private Function CreateDataSet() As DataTable

        Dim ds As New DataSet()
        Dim dt As DataTable

        dt = ds.Tables.Add("sample")

        dt.Columns.Add("店舗")
        dt.Columns.Add("2021年")
        dt.Columns.Add("2022年")
        dt.Columns.Add("2023年")

        dt.Rows.Add({1, 100, 110, 120})
        dt.Rows.Add({2, 200, 210, 220})
        dt.Rows.Add({3, 300, 310, 320})
        dt.Rows.Add({4, 400, 410, 420})
        dt.Rows.Add({5, 500, 510, 520})

        CreateDataSet = dt

    End Function

    Friend WithEvents DataGridView1 As DataGridView

End Class
