﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltotall = New System.Windows.Forms.Label()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.txtPerday = New System.Windows.Forms.TextBox()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCal2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมตัวอย่างการคิดค่าแรง"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(77, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชั่วโมงการทำงาน"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(77, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 38)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "อัตราคาจ้างต่อชั่วโมง"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(77, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 38)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "คิดเป็นเงิน"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(77, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 38)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "หัวเสียภาษี ณ ที่จ่าย"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotall
        '
        Me.lbltotall.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbltotall.ForeColor = System.Drawing.Color.Red
        Me.lbltotall.Location = New System.Drawing.Point(329, 256)
        Me.lbltotall.Name = "lbltotall"
        Me.lbltotall.Size = New System.Drawing.Size(140, 38)
        Me.lbltotall.TabIndex = 1
        Me.lbltotall.Text = " "
        Me.lbltotall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltax
        '
        Me.lbltax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbltax.ForeColor = System.Drawing.Color.Red
        Me.lbltax.Location = New System.Drawing.Point(329, 323)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(140, 38)
        Me.lbltax.TabIndex = 1
        Me.lbltax.Text = " "
        Me.lbltax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHour
        '
        Me.txtHour.Location = New System.Drawing.Point(332, 110)
        Me.txtHour.Multiline = True
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(137, 38)
        Me.txtHour.TabIndex = 1
        '
        'txtPerday
        '
        Me.txtPerday.Location = New System.Drawing.Point(332, 183)
        Me.txtPerday.Multiline = True
        Me.txtPerday.Name = "txtPerday"
        Me.txtPerday.Size = New System.Drawing.Size(137, 38)
        Me.txtPerday.TabIndex = 2
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(332, 390)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(75, 23)
        Me.btnCal.TabIndex = 3
        Me.btnCal.Text = "คำนวณ"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(433, 390)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCal2
        '
        Me.btnCal2.Location = New System.Drawing.Point(529, 390)
        Me.btnCal2.Name = "btnCal2"
        Me.btnCal2.Size = New System.Drawing.Size(75, 23)
        Me.btnCal2.TabIndex = 3
        Me.btnCal2.Text = "คำนวณ"
        Me.btnCal2.UseVisualStyleBackColor = True
        '
        'Frmlab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCal2)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.txtPerday)
        Me.Controls.Add(Me.txtHour)
        Me.Controls.Add(Me.lbltax)
        Me.Controls.Add(Me.lbltotall)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frmlab1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbltotall As Label
    Friend WithEvents lbltax As Label
    Friend WithEvents txtHour As TextBox
    Friend WithEvents txtPerday As TextBox
    Friend WithEvents btnCal As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCal2 As Button
End Class
