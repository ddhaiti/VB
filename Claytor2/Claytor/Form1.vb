Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = Now

        Me.Height = 500
        Me.Width = 700
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As About = New About
        about.Show()
    End Sub

    Private Sub GuestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestToolStripMenuItem.Click
        Dim guest As Guest = Guest.Instance
        guest.MdiParent = Me
        guest.Show()
        guest.Focus()
    End Sub

    Private Sub ReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationsToolStripMenuItem.Click
        Dim reservation As Reservation = Reservation.Instance
        reservation.MdiParent = Me
        reservation.Show()
        reservation.Focus()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem.Click
        Dim room As Room = Room.Instance
        room.MdiParent = Me
        room.Show()
        room.Focus()
    End Sub

    Private Sub RoomToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem1.Click
        Dim room As Room = Room.Instance
        room.MdiParent = Me
        room.Show()
        room.Focus()
    End Sub

    Private Sub GuestToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GuestToolStripMenuItem1.Click
        Dim guest As Guest = Guest.Instance
        guest.MdiParent = Me
        guest.Show()
        guest.Focus()
    End Sub

    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click
        Dim reservation As Reservation = Reservation.Instance
        reservation.MdiParent = Me
        reservation.Show()
        reservation.Focus()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim room As Room = Room.Instance
        room.MdiParent = Me
        room.Show()
        room.Focus()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim guest As Guest = Guest.Instance
        guest.MdiParent = Me
        guest.Show()
        guest.Focus()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim reservation As Reservation = Reservation.Instance
        reservation.MdiParent = Me
        reservation.Show()
        reservation.Focus()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = Now
    End Sub

    Private Sub TileHorizontallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontallyToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticallyToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
