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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        avatar = New PictureBox()
        Timer1 = New Timer(components)
        enemy = New PictureBox()
        coin = New PictureBox()
        enemy2 = New PictureBox()
        CType(avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(coin, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' avatar
        ' 
        avatar.Image = CType(resources.GetObject("avatar.Image"), Image)
        avatar.Location = New Point(771, 12)
        avatar.Name = "avatar"
        avatar.Size = New Size(120, 123)
        avatar.SizeMode = PictureBoxSizeMode.Zoom
        avatar.TabIndex = 0
        avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' enemy
        ' 
        enemy.Image = CType(resources.GetObject("enemy.Image"), Image)
        enemy.Location = New Point(12, 480)
        enemy.Name = "enemy"
        enemy.Size = New Size(120, 123)
        enemy.SizeMode = PictureBoxSizeMode.Zoom
        enemy.TabIndex = 1
        enemy.TabStop = False
        ' 
        ' coin
        ' 
        coin.Image = CType(resources.GetObject("coin.Image"), Image)
        coin.Location = New Point(12, 12)
        coin.Name = "coin"
        coin.Size = New Size(47, 43)
        coin.SizeMode = PictureBoxSizeMode.Zoom
        coin.TabIndex = 2
        coin.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = CType(resources.GetObject("enemy2.Image"), Image)
        enemy2.Location = New Point(121, 273)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(120, 123)
        enemy2.SizeMode = PictureBoxSizeMode.Zoom
        enemy2.TabIndex = 3
        enemy2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(903, 615)
        Controls.Add(enemy2)
        Controls.Add(coin)
        Controls.Add(enemy)
        Controls.Add(avatar)
        Name = "Form1"
        Text = "7"
        CType(avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(coin, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents enemy As PictureBox
    Friend WithEvents coin As PictureBox
    Friend WithEvents enemy2 As PictureBox

End Class
