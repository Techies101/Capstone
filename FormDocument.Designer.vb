﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDocument
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDocument))
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Btn3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn7 = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn8 = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn9 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn4 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Engravers MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(303, 6)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.NetResize1.SetResizeFont(Me.Guna2HtmlLabel12, False)
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(280, 39)
        Me.Guna2HtmlLabel12.TabIndex = 55
        Me.Guna2HtmlLabel12.Text = "DOCUMENTS"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderThickness = 5
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel12)
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(733, 41)
        Me.Guna2Panel3.TabIndex = 60
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(26, 48)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(195, 29)
        Me.Guna2HtmlLabel7.TabIndex = 63
        Me.Guna2HtmlLabel7.Text = "Payable Documents"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(26, 298)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(237, 29)
        Me.Guna2HtmlLabel1.TabIndex = 64
        Me.Guna2HtmlLabel1.Text = "Not Payable Documents"
        '
        'Btn3
        '
        Me.Btn3.Animated = True
        Me.Btn3.BorderRadius = 8
        Me.Btn3.BorderThickness = 3
        Me.Btn3.CheckedState.Parent = Me.Btn3
        Me.Btn3.CustomBorderColor = System.Drawing.Color.White
        Me.Btn3.CustomImages.Parent = Me.Btn3
        Me.Btn3.FillColor = System.Drawing.Color.Maroon
        Me.Btn3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.ForeColor = System.Drawing.Color.White
        Me.Btn3.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Btn3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn3.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn3.HoverState.Parent = Me.Btn3
        Me.Btn3.Image = CType(resources.GetObject("Btn3.Image"), System.Drawing.Image)
        Me.Btn3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn3.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn3.Location = New System.Drawing.Point(13, 39)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.ShadowDecoration.Parent = Me.Btn3
        Me.Btn3.Size = New System.Drawing.Size(207, 68)
        Me.Btn3.TabIndex = 23
        Me.Btn3.Text = "CERTIFICATE                                                                      " &
    " OF INDIGENCY"
        Me.Btn3.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Btn7
        '
        Me.Btn7.Animated = True
        Me.Btn7.BorderRadius = 8
        Me.Btn7.BorderThickness = 3
        Me.Btn7.CheckedState.Parent = Me.Btn7
        Me.Btn7.CustomBorderColor = System.Drawing.Color.White
        Me.Btn7.CustomImages.Parent = Me.Btn7
        Me.Btn7.FillColor = System.Drawing.Color.Maroon
        Me.Btn7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.ForeColor = System.Drawing.Color.White
        Me.Btn7.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Btn7.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn7.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn7.HoverState.Parent = Me.Btn7
        Me.Btn7.Image = CType(resources.GetObject("Btn7.Image"), System.Drawing.Image)
        Me.Btn7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn7.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn7.Location = New System.Drawing.Point(248, 40)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.ShadowDecoration.Parent = Me.Btn7
        Me.Btn7.Size = New System.Drawing.Size(207, 68)
        Me.Btn7.TabIndex = 27
        Me.Btn7.Text = "SPES                                                     (School Youth)"
        Me.Btn7.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Btn8
        '
        Me.Btn8.Animated = True
        Me.Btn8.BorderRadius = 8
        Me.Btn8.BorderThickness = 3
        Me.Btn8.CheckedState.Parent = Me.Btn8
        Me.Btn8.CustomBorderColor = System.Drawing.Color.White
        Me.Btn8.CustomImages.Parent = Me.Btn8
        Me.Btn8.FillColor = System.Drawing.Color.Maroon
        Me.Btn8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.ForeColor = System.Drawing.Color.White
        Me.Btn8.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Btn8.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn8.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn8.HoverState.Parent = Me.Btn8
        Me.Btn8.Image = CType(resources.GetObject("Btn8.Image"), System.Drawing.Image)
        Me.Btn8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn8.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn8.Location = New System.Drawing.Point(486, 40)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.ShadowDecoration.Parent = Me.Btn8
        Me.Btn8.Size = New System.Drawing.Size(207, 68)
        Me.Btn8.TabIndex = 28
        Me.Btn8.Text = "SPES                                     (Out of School Youth)"
        Me.Btn8.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Btn9
        '
        Me.Btn9.Animated = True
        Me.Btn9.BorderRadius = 8
        Me.Btn9.BorderThickness = 3
        Me.Btn9.CheckedState.Parent = Me.Btn9
        Me.Btn9.CustomBorderColor = System.Drawing.Color.White
        Me.Btn9.CustomImages.Parent = Me.Btn9
        Me.Btn9.FillColor = System.Drawing.Color.Maroon
        Me.Btn9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.ForeColor = System.Drawing.Color.White
        Me.Btn9.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Btn9.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn9.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn9.HoverState.Parent = Me.Btn9
        Me.Btn9.Image = CType(resources.GetObject("Btn9.Image"), System.Drawing.Image)
        Me.Btn9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn9.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn9.Location = New System.Drawing.Point(248, 129)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.ShadowDecoration.Parent = Me.Btn9
        Me.Btn9.Size = New System.Drawing.Size(207, 68)
        Me.Btn9.TabIndex = 29
        Me.Btn9.Text = "OATH OF      UNDERTAKING/                  CERTIFICATION"
        Me.Btn9.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderThickness = 4
        Me.Guna2Panel2.Controls.Add(Me.Btn9)
        Me.Guna2Panel2.Controls.Add(Me.Btn8)
        Me.Guna2Panel2.Controls.Add(Me.Btn7)
        Me.Guna2Panel2.Controls.Add(Me.Btn3)
        Me.Guna2Panel2.Location = New System.Drawing.Point(14, 307)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(704, 225)
        Me.Guna2Panel2.TabIndex = 62
        '
        'Btn6
        '
        Me.Btn6.Animated = True
        Me.Btn6.BorderRadius = 8
        Me.Btn6.BorderThickness = 3
        Me.Btn6.CheckedState.Parent = Me.Btn6
        Me.Btn6.CustomBorderColor = System.Drawing.Color.White
        Me.Btn6.CustomImages.Parent = Me.Btn6
        Me.Btn6.FillColor = System.Drawing.Color.Maroon
        Me.Btn6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.ForeColor = System.Drawing.Color.White
        Me.Btn6.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Btn6.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn6.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn6.HoverState.Parent = Me.Btn6
        Me.Btn6.Image = CType(resources.GetObject("Btn6.Image"), System.Drawing.Image)
        Me.Btn6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn6.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn6.Location = New System.Drawing.Point(485, 38)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.ShadowDecoration.Parent = Me.Btn6
        Me.Btn6.Size = New System.Drawing.Size(207, 68)
        Me.Btn6.TabIndex = 26
        Me.Btn6.Text = "CERTIFICATE OF                                                                   " &
    "                              SOLO PARENT"
        Me.Btn6.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Btn2
        '
        Me.Btn2.Animated = True
        Me.Btn2.BorderRadius = 8
        Me.Btn2.BorderThickness = 3
        Me.Btn2.CheckedState.Parent = Me.Btn2
        Me.Btn2.CustomBorderColor = System.Drawing.Color.White
        Me.Btn2.CustomImages.Parent = Me.Btn2
        Me.Btn2.FillColor = System.Drawing.Color.Maroon
        Me.Btn2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.ForeColor = System.Drawing.Color.White
        Me.Btn2.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Btn2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn2.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn2.HoverState.Parent = Me.Btn2
        Me.Btn2.Image = CType(resources.GetObject("Btn2.Image"), System.Drawing.Image)
        Me.Btn2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn2.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn2.Location = New System.Drawing.Point(247, 38)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.ShadowDecoration.Parent = Me.Btn2
        Me.Btn2.Size = New System.Drawing.Size(207, 68)
        Me.Btn2.TabIndex = 22
        Me.Btn2.Text = "BUSINESS                                                                         " &
    "             CLEARANCE"
        Me.Btn2.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Btn1
        '
        Me.Btn1.Animated = True
        Me.Btn1.BorderRadius = 8
        Me.Btn1.BorderThickness = 3
        Me.Btn1.CheckedState.Parent = Me.Btn1
        Me.Btn1.CustomBorderColor = System.Drawing.Color.White
        Me.Btn1.CustomImages.Parent = Me.Btn1
        Me.Btn1.FillColor = System.Drawing.Color.Maroon
        Me.Btn1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.ForeColor = System.Drawing.Color.White
        Me.Btn1.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Btn1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn1.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn1.HoverState.Parent = Me.Btn1
        Me.Btn1.Image = CType(resources.GetObject("Btn1.Image"), System.Drawing.Image)
        Me.Btn1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn1.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn1.Location = New System.Drawing.Point(12, 38)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.ShadowDecoration.Parent = Me.Btn1
        Me.Btn1.Size = New System.Drawing.Size(207, 68)
        Me.Btn1.TabIndex = 21
        Me.Btn1.Text = "BARANGAY               CLEARANCE"
        Me.Btn1.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderThickness = 4
        Me.Guna2Panel1.Controls.Add(Me.Btn5)
        Me.Guna2Panel1.Controls.Add(Me.Btn1)
        Me.Guna2Panel1.Controls.Add(Me.Btn2)
        Me.Guna2Panel1.Controls.Add(Me.Btn6)
        Me.Guna2Panel1.Controls.Add(Me.Btn4)
        Me.Guna2Panel1.Location = New System.Drawing.Point(14, 57)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(704, 225)
        Me.Guna2Panel1.TabIndex = 61
        '
        'Btn5
        '
        Me.Btn5.Animated = True
        Me.Btn5.BorderRadius = 8
        Me.Btn5.BorderThickness = 3
        Me.Btn5.CheckedState.Parent = Me.Btn5
        Me.Btn5.CustomBorderColor = System.Drawing.Color.White
        Me.Btn5.CustomImages.Parent = Me.Btn5
        Me.Btn5.FillColor = System.Drawing.Color.Maroon
        Me.Btn5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.ForeColor = System.Drawing.Color.White
        Me.Btn5.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Btn5.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn5.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn5.HoverState.Parent = Me.Btn5
        Me.Btn5.Image = CType(resources.GetObject("Btn5.Image"), System.Drawing.Image)
        Me.Btn5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn5.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn5.Location = New System.Drawing.Point(372, 128)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.ShadowDecoration.Parent = Me.Btn5
        Me.Btn5.Size = New System.Drawing.Size(207, 68)
        Me.Btn5.TabIndex = 25
        Me.Btn5.Text = "CERTIFICATE OF                                                                   " &
    "                                 NON RESIDENCY"
        Me.Btn5.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Btn4
        '
        Me.Btn4.Animated = True
        Me.Btn4.BorderRadius = 8
        Me.Btn4.BorderThickness = 3
        Me.Btn4.CheckedState.Parent = Me.Btn4
        Me.Btn4.CustomBorderColor = System.Drawing.Color.White
        Me.Btn4.CustomImages.Parent = Me.Btn4
        Me.Btn4.FillColor = System.Drawing.Color.Maroon
        Me.Btn4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.ForeColor = System.Drawing.Color.White
        Me.Btn4.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Btn4.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn4.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn4.HoverState.Parent = Me.Btn4
        Me.Btn4.Image = CType(resources.GetObject("Btn4.Image"), System.Drawing.Image)
        Me.Btn4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn4.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn4.Location = New System.Drawing.Point(120, 128)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.ShadowDecoration.Parent = Me.Btn4
        Me.Btn4.Size = New System.Drawing.Size(207, 68)
        Me.Btn4.TabIndex = 24
        Me.Btn4.Text = "CERTIFICATE                                        OF RESIDENCY"
        Me.Btn4.TextOffset = New System.Drawing.Point(15, 0)
        '
        'FormDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(731, 543)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDocument"
        Me.Text = "FromDocumentSection"
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Btn9 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Btn5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn4 As Guna.UI2.WinForms.Guna2Button
End Class
