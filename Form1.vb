Public Class Form1
    Dim Bow, Boomerang, Glove, Sword, Armor, Shield, Magic, MedallionCount, MireMedallion, TurtleMedallion, EPReward, DPReward, TOHReward, PODReward, SPReward, SWReward, TTReward, IPReward, MMReward, TRReward, CrystalCount, FairyCrystal, PendantCount, Available, AgaTree, Library, Maze, SpecRock, EtherTab, Floating, DPLedge, BombosTab, ZoraLedge, LakeIsle, Pedestal, Bumper As Integer
    Dim Hookshot, Bombs, Powder, FireRod, IceRod, Bombos, Ether, Quake, Lamp, Hammer, Flute, Net, Book, Bottle, Somaria, Byrna, Cape, Mirror, Boots, Flippers, Pearl, Mushroom, Shovel, Aganhim, GreenPendant, TRAccess As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

        Dim nobow As New Bitmap(My.Resources.nobow)
        Dim noboomerang As New Bitmap(My.Resources.redboom)
        Dim nohook As New Bitmap(My.Resources.hookshot)
        Dim nobombs As New Bitmap(My.Resources.bombs)
        Dim nopowder As New Bitmap(My.Resources.powder)
        Dim nofirerod As New Bitmap(My.Resources.firerod)
        Dim noicerod As New Bitmap(My.Resources.icerod)
        Dim nobombos As New Bitmap(My.Resources.bombos)
        Dim noether As New Bitmap(My.Resources.ether)
        Dim noquake As New Bitmap(My.Resources.quake)
        Dim nolamp As New Bitmap(My.Resources.lamp)
        Dim nohammer As New Bitmap(My.Resources.hammer)
        Dim noflute As New Bitmap(My.Resources.flute)
        Dim nobugnet As New Bitmap(My.Resources.bugnet)
        Dim nobook As New Bitmap(My.Resources.book)
        Dim nobottle As New Bitmap(My.Resources.bottle)
        Dim nosomaria As New Bitmap(My.Resources.somaria)
        Dim nobyrna As New Bitmap(My.Resources.byrna)
        Dim nocape As New Bitmap(My.Resources.cape)
        Dim nomirror As New Bitmap(My.Resources.mirror)
        Dim noboots As New Bitmap(My.Resources.boots)
        Dim noglove As New Bitmap(My.Resources.glove)
        Dim noflippers As New Bitmap(My.Resources.flippers)
        Dim nopearl As New Bitmap(My.Resources.pearl)
        Dim nomushroom As New Bitmap(My.Resources.mushroom)
        Dim noshovel As New Bitmap(My.Resources.shovel)
        Dim nosword As New Bitmap(My.Resources.nosword)
        Dim noshield As New Bitmap(My.Resources.shield1)
        Dim noaganhim As New Bitmap(My.Resources.aganhim)
        Dim imgattr As New Imaging.ImageAttributes()
        imgattr.SetColorMatrix(grayscale)
        Using g As Graphics = Graphics.FromImage(nobow)
            g.DrawImage(nobow, New Rectangle(0, 0, nobow.Width, nobow.Height),
                    0, 0, nobow.Width, nobow.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noboomerang)
            g.DrawImage(noboomerang, New Rectangle(0, 0, noboomerang.Width, noboomerang.Height),
                    0, 0, noboomerang.Width, noboomerang.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nohook)
            g.DrawImage(nohook, New Rectangle(0, 0, nohook.Width, nohook.Height),
                    0, 0, nohook.Width, nohook.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobombs)
            g.DrawImage(nobombs, New Rectangle(0, 0, nobombs.Width, nobombs.Height),
                    0, 0, nobombs.Width, nobombs.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nopowder)
            g.DrawImage(nopowder, New Rectangle(0, 0, nopowder.Width, nopowder.Height),
                    0, 0, nopowder.Width, nopowder.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nofirerod)
            g.DrawImage(nofirerod, New Rectangle(0, 0, nofirerod.Width, nofirerod.Height),
                    0, 0, nofirerod.Width, nofirerod.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noicerod)
            g.DrawImage(noicerod, New Rectangle(0, 0, noicerod.Width, noicerod.Height),
                    0, 0, noicerod.Width, noicerod.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobombos)
            g.DrawImage(nobombos, New Rectangle(0, 0, nobombos.Width, nobombos.Height),
                    0, 0, nobombos.Width, nobombos.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noether)
            g.DrawImage(noether, New Rectangle(0, 0, noether.Width, noether.Height),
                    0, 0, noether.Width, noether.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noquake)
            g.DrawImage(noquake, New Rectangle(0, 0, noquake.Width, noquake.Height),
                    0, 0, noquake.Width, noquake.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nolamp)
            g.DrawImage(nolamp, New Rectangle(0, 0, nolamp.Width, nolamp.Height),
                    0, 0, nolamp.Width, nolamp.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nohammer)
            g.DrawImage(nohammer, New Rectangle(0, 0, nohammer.Width, nohammer.Height),
                    0, 0, nohammer.Width, nohammer.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noflute)
            g.DrawImage(noflute, New Rectangle(0, 0, noflute.Width, noflute.Height),
                    0, 0, noflute.Width, noflute.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobugnet)
            g.DrawImage(nobugnet, New Rectangle(0, 0, nobugnet.Width, nobugnet.Height),
                    0, 0, nobugnet.Width, nobugnet.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobook)
            g.DrawImage(nobook, New Rectangle(0, 0, nobook.Width, nobook.Height),
                    0, 0, nobook.Width, nobook.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobottle)
            g.DrawImage(nobottle, New Rectangle(0, 0, nobottle.Width, nobottle.Height),
                    0, 0, nobottle.Width, nobottle.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nosomaria)
            g.DrawImage(nosomaria, New Rectangle(0, 0, nosomaria.Width, nosomaria.Height),
                    0, 0, nosomaria.Width, nosomaria.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobyrna)
            g.DrawImage(nobyrna, New Rectangle(0, 0, nobyrna.Width, nobyrna.Height),
                    0, 0, nobyrna.Width, nobyrna.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nocape)
            g.DrawImage(nocape, New Rectangle(0, 0, nocape.Width, nocape.Height),
                    0, 0, nocape.Width, nocape.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nomirror)
            g.DrawImage(nomirror, New Rectangle(0, 0, nomirror.Width, nomirror.Height),
                    0, 0, nomirror.Width, nomirror.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noboots)
            g.DrawImage(noboots, New Rectangle(0, 0, noboots.Width, noboots.Height),
                    0, 0, noboots.Width, noboots.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noglove)
            g.DrawImage(noglove, New Rectangle(0, 0, noglove.Width, noglove.Height),
                    0, 0, noglove.Width, noglove.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noflippers)
            g.DrawImage(noflippers, New Rectangle(0, 0, noflippers.Width, noflippers.Height),
                    0, 0, noflippers.Width, noflippers.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nopearl)
            g.DrawImage(nopearl, New Rectangle(0, 0, nopearl.Width, nopearl.Height),
                    0, 0, nopearl.Width, nopearl.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nomushroom)
            g.DrawImage(nomushroom, New Rectangle(0, 0, nomushroom.Width, nomushroom.Height),
                    0, 0, nomushroom.Width, nomushroom.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noshovel)
            g.DrawImage(noshovel, New Rectangle(0, 0, noshovel.Width, noshovel.Height),
                    0, 0, noshovel.Width, noshovel.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nosword)
            g.DrawImage(nosword, New Rectangle(0, 0, nosword.Width, nosword.Height),
                    0, 0, nosword.Width, nosword.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noshield)
            g.DrawImage(noshield, New Rectangle(0, 0, noshield.Width, noshield.Height),
                    0, 0, noshield.Width, noshield.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noaganhim)
            g.DrawImage(noaganhim, New Rectangle(0, 0, noaganhim.Width, noaganhim.Height),
                    0, 0, noaganhim.Width, noaganhim.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        BowButton.Image = nobow
        BoomButton.Image = noboomerang
        HookButton.Image = nohook
        BombButton.Image = nobombs
        PowderButton.Image = nopowder
        FireButton.Image = nofirerod
        IceButton.Image = noicerod
        BombosButton.Image = nobombos
        EtherButton.Image = noether
        QuakeButton.Image = noquake
        LampButton.Image = nolamp
        HammerButton.Image = nohammer
        FluteButton.Image = noflute
        NetButton.Image = nobugnet
        BookButton.Image = nobook
        BottleButton.Image = nobottle
        SomariaButton.Image = nosomaria
        ByrnaButton.Image = nobyrna
        CapeButton.Image = nocape
        MirrorButton.Image = nomirror
        BootButton.Image = noboots
        GloveButton.Image = noglove
        FlipperButton.Image = noflippers
        PearlButton.Image = nopearl
        MushButton.Image = nomushroom
        ShovelButton.Image = noshovel
        SwordButton.Image = nosword
        ShieldButton.Image = noshield
    End Sub

    ''CheckBox Clearable/SequenceBreak/PartialClearable/Off
    Private Sub CCLR (ByVal Label as System.Windows.Forms.CheckBox)
        Label.Enabled = True
        Label.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub CSQB (ByVal Label as System.Windows.Forms.CheckBox)
        Label.Enabled = True
        Label.BackColor = Color.Orange
    End Sub

    Private Sub CPCLR (ByVal Label as System.Windows.Forms.CheckBox)
        Label.Enabled = True
        Label.BackColor = Color.Yellow
    End Sub
        
    Private Sub COFF (ByVal Label as System.Windows.Forms.CheckBox)
        Label.Enabled = False
        Label.Checked = False
        Label.BackColor = Color.Red
    End Sub

    ''Labels Clearable/SequenceBreak/PartialClearable/Off
    Private Sub LCLR (ByVal Label as System.Windows.Forms.Label)
        Label.BackColor = Color.Green
        Label.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub LSQB (ByVal Label as System.Windows.Forms.Label)
        Label.BackColor = Color.Orange
        Label.ForeColor = Color.Black
    End Sub

    Private Sub LPCLR (ByVal Label as System.Windows.Forms.Label)
        Label.BackColor = Color.Yellow
        Label.ForeColor = Color.Black
    End Sub
        
    Private Sub LOFF (ByVal Label as System.Windows.Forms.Label)
        Label.BackColor = Color.Red
        Label.ForeColor = Color.Black
    End Sub

    Private Sub LChests (Label as System.Windows.Forms.Label, Count as Integer, Color As System.Drawing.Color)
        Label.Text = Count
        Label.ForeColor = Color
    End Sub

    '' Change label color to green if Text = Max. If Incr <> 0, change it b4 coloring. If Inv = 1, change to green at 0
    Private Sub NumChange (ByVal Label as System.Windows.Forms.Label, ByVal Max as Integer, Optional ByVal Incr as Integer = 0, Optional ByVal Inv as Integer = 0)
        If Incr = 1 And Label.Text < Max Then Label.Text += 1
        If Incr = -1 And Label.Text > 0  Then Label.Text -= 1
        If Inv = 1 Then
			If Label.Text = 0 Then Label.BackColor = Color.Green Else Label.BackColor = Color.Black
		End If
		If Inv = 0 Then
			If Label.Text = Max Then Label.BackColor = Color.Green Else Label.BackColor = Color.Black
		End If
    End Sub
	
    Private Sub AllCheck()
        HCCheck()
        EPCheck()
        DPCheck()
        TOHCheck()
        AgaCheck()
        PODCheck()
        SPCheck()
        SWCheck()
        TTCheck()
        IPCheck()
        MMCheck()
        TRCheck()
        CrystalCheck()
        GTCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Function canExtendMagic(Optional Req as Integer = 2)
        Dim CalcMag as Integer = 0
        If Magic = 2 Then
            CalcMag = 4
        ElseIf Magic = 1 Then
            CalcMag = 2
        Else
            CalcMag = 1
        End If
        CalcMag *= (BottleNumber.Text +1)
        If CalcMag >= Req Then
            Return 1
        End If
        Return 0
    End Function

    ''Check if Sword Or Hammer for Swordless, Optional Parameter to check Swordlvl and if Hammer is needed in SL, like open curtains, dont need anything more)
    Private Function SLcheck(Optional SwordLv as Integer = 1, Optional NeedWeap as Integer = 1)
        If ComboBox1.SelectedIndex > 5 And NeedWeap And Hammer Then
            Return 1
        ElseIf ComboBox1.SelectedIndex > 5 And NeedWeap = 0 Then
            Return 1
        ElseIf ComboBox1.SelectedIndex < 6 And Sword >= SwordLv Then
            Return 1
        End If
        Return 0
    End Function
        
    Private Function TRMedCheck()
       If SLcheck() And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos) Or (TurtleMedallion = 2 And Ether) Or (TurtleMedallion = 3 And Quake)) Then
            Return 1
        End If
        Return 0
    End Function

    Private Function MMMedCheck()
        If SLcheck() And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos) Or (MireMedallion = 2 And Ether) Or (MireMedallion = 3 And Quake)) Then
            Return 1
        End If
        Return 0
    End Function

    Private Function NormalDWMainAcc()
        If (Pearl And (Glove = 2 Or (Hammer And Glove > 0) Or (Aganhim And Hookshot And (Flippers Or Hammer Or Glove > 0)))) Then
            Return 1
        End If
        Return 0
    End Function

    Private Function NormalDWEastAcc()
        If Aganhim Or (Pearl And (Hammer or Flippers) And (Glove = 2 Or (Hammer And Glove))) Then
            Return 1
        End If
        Return 0
    End Function
    
    Private Function NormalLWDMAcc()
        If (Glove > 0 And Lamp)  Or Flute Then
            Return 1
        ElseIf Glove > 0 Then
            Return 2
        End If
        Return 0
    End Function
    
    Private Function NormalDWDMAcc()
        If Glove = 2 And (Hookshot Or (Mirror And Hammer)) And NormalLWDMAcc() Then
            Return 1
        End If
        Return 0
    End Function

    Private Function NormalDWMireAcc()
        If Glove = 2 And Flute Then
            Return 1
        End If
        Return 0
    End Function

    Private Function InvertedLWAcc()
        If Aganhim Or (Pearl And (Glove = 2 Or (Hammer And Glove))) Then
            Return 1
        End If
        Return 0
    End Function
    
    Private Sub Form1_KeyDown() Handles Me.KeyDown
        If My.Computer.Keyboard.ShiftKeyDown Then
            HCLabel.Text = "H"
            EPLabel.Text = "1"
            DPLabel.Text = "2"
            TOHLabel.Text = "3"
            PODLabel.Text = "4"
            SPLabel.Text = "5"
            SWLabel.Text = "6"
            TTLabel.Text = "7"
            IPLabel.Text = "8"
            MMLabel.Text = "9"
            TRLabel.Text = "0"
        End If
    End Sub

    Private Sub Form1_KeyUp() Handles Me.KeyUp
        HCLabel.Text = "HC"
        EPLabel.Text = "EP"
        DPLabel.Text = "DP"
        TOHLabel.Text = "TOH"
        PODLabel.Text = "POD"
        SPLabel.Text = "SP"
        SWLabel.Text = "SW"
        TTLabel.Text = "TT"
        IPLabel.Text = "IP"
        MMLabel.Text = "MM"
        TRLabel.Text = "TR"
    End Sub


    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case (e.KeyChar)
            Case "H", "h"
                If My.Computer.Keyboard.ShiftKeyDown Then
                    If ComboBox1.SelectedIndex Mod 3 <> 1 Then HCPrizes.Text = 0 Else HCChests.Text = 0
                End If
            Case "!"
                EPBoss.Checked = True
                EPBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then EPPrizes.Text = 0 Else EPChests.Text = 0
                EPLabel2.BackColor = Color.Green
            Case "@"
                DPBoss.Checked = True
                DPBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then DPPrizes.Text = 0 Else DPChests.Text = 0
                DPLabel2.BackColor = Color.Green
            Case "#"
                HeraBoss.Checked = True
                HeraBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then TOHPrizes.Text = 0 Else TOHChests.Text = 0
                TOHLabel2.BackColor = Color.Green
            Case "$"
                PODBoss.Checked = True
                PODBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then PODPrizes.Text = 0 Else PODChests.Text = 0
                PODLabel2.BackColor = Color.Green
            Case "%"
                SPBoss.Checked = True
                SPBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then SPPrizes.Text = 0 Else SPChests.Text = 0
                SPLabel2.BackColor = Color.Green
            Case "^"
                SWBoss.Checked = True
                SWBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then SWPrizes.Text = 0 Else SWChests.Text = 0
                SWLabel2.BackColor = Color.Green
            Case "&"
                TTBoss.Checked = True
                TTBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then TTPrizes.Text = 0 Else TTChests.Text = 0
                TTLabel2.BackColor = Color.Green
            Case "*"
                IPBoss.Checked = True
                IPBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then IPPrizes.Text = 0 Else IPChests.Text = 0
                IPLabel2.BackColor = Color.Green
            Case "("
                MMBoss.Checked = True
                MMBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then MMPrizes.Text = 0 Else MMChests.Text = 0
                MMLabel2.BackColor = Color.Green
            Case ")"
                TRBoss.Checked = True
                TRBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then TRPrizes.Text = 0 Else TRChests.Text = 0
                TRLabel2.BackColor = Color.Green
        End Select
        CrystalCheck()
    End Sub

    Private Sub HideKeysMap(i as Integer)
        If i = 1 Then
                For Each Check as System.Windows.Forms.CheckBox in {EPMap, EPBigKey, DPMap, DPBigKey, HeraMap, HeraBigKey, PODMap, PODBigKey, SPMap, SPBigKey, SWMap, SWBigKey, TTMap, TTBigKey, IPMap, IPBigKey, MMMap, MMBigKey, TRMap, TRBigKey, GTBigKey}
                    Check.Visible = False
                Next
                For Each Label as System.Windows.Forms.Label in {HCKeys, EPKeys, DPKeys, TOHKeys, PODKeys, SPKeys, SWKeys, TTKeys, IPKeys, MMKeys, TRKeys, AGKeys, GTKeys, AGLabel, AGChests, AGPrizes, GTLabel, GTChests}
                    Label.Visible = False
                Next
                AGBorder.Visible = False
                GTBorder.Visible = False
                
                For Each Label as System.Windows.Forms.Label in {HCPrizes, EPPrizes, DPPrizes, TOHPrizes, PODPrizes, SPPrizes, SWPrizes, TTPrizes, IPPrizes, MMPrizes, TRPrizes}
                    Label.Visible = True
                Next
                
        Else
                For Each Check as System.Windows.Forms.CheckBox in {EPMap, EPBigKey, DPMap, DPBigKey, HeraMap, HeraBigKey, PODMap, PODBigKey, SPMap, SPBigKey, SWMap, SWBigKey, TTMap, TTBigKey, IPMap, IPBigKey, MMMap, MMBigKey, TRMap, TRBigKey, GTBigKey}
                    Check.Visible = True
                Next
                For Each Label as System.Windows.Forms.Label in {HCKeys, EPKeys, DPKeys, TOHKeys, PODKeys, SPKeys, SWKeys, TTKeys, IPKeys, MMKeys, TRKeys, AGKeys, GTKeys, AGLabel, AGChests, AGPrizes, GTLabel, GTChests}
                    Label.Visible = True
                Next
                AGBorder.Visible = True
                GTBorder.Visible = True
                For Each Label as System.Windows.Forms.Label in {HCPrizes, EPPrizes, DPPrizes, TOHPrizes, PODPrizes, SPPrizes, SWPrizes, TTPrizes, IPPrizes, MMPrizes, TRPrizes}
                    Label.Visible = False
                Next
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0,3,6,9
                If ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 9 Then
                    SwordButton.Visible = False
                Else 
                    SwordButton.Visible = True
                End If
                HideKeysMap(1)
                EPReward = 0
                DPReward = 0
                TOHReward = 0
                PODReward = 0
                SPReward = 0
                SWReward = 0
                TTReward = 0
                IPReward = 0
                MMReward = 0
                TRReward = 0
                For Each Pic in {EPButton, DPButton, TOHButton, PODButton, SPButton, SWButton, TTButton, IPButton, MMButton, TRButton}
                    Pic.Image = My.Resources.crystal
                Next
                EPBoss.Left = 115
                DPBoss.Left = 115
                HeraBoss.Left = 115
                PODBoss.Left = 115
                SPBoss.Left = 115
                SWBoss.Left = 317
                TTBoss.Left = 317
                IPBoss.Left = 317
                MMBoss.Left = 317
                TRBoss.Left = 317
                For Each Label as System.Windows.Forms.Label in {HCChests, AGChests, EPChests, DPChests, TOHChests, PODChests, SPChests, SWChests, TTChests, IPChests, MMChests, TRChests, GTChests}
                    Label.Text = 0
                Next
                HCPrizes.Text = 6
                EPPrizes.Text = 3
                DPPrizes.Text = 2
                TOHPrizes.Text = 2
                PODPrizes.Text = 5
                SPPrizes.Text = 6
                SWPrizes.Text = 2
                TTPrizes.Text = 4
                IPPrizes.Text = 3
                MMPrizes.Text = 2
                TRPrizes.Text = 5
            Case 1,4,7,10
                If ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
                    SwordButton.Visible = False
                Else 
                    SwordButton.Visible = True
                End If
                HideKeysMap(0)
                EPReward = -1
                DPReward = -1
                TOHReward = -1
                PODReward = -1
                SPReward = -1
                SWReward = -1
                TTReward = -1
                IPReward = -1
                MMReward = -1
                TRReward = -1
                For Each Pic in {EPButton, DPButton, TOHButton, PODButton, SPButton, SWButton, TTButton, IPButton, MMButton, TRButton}
                    Pic.Image = Nothing
                Next
                EPBoss.Left = 163
                DPBoss.Left = 163
                HeraBoss.Left = 163
                PODBoss.Left = 163
                SPBoss.Left = 163
                SWBoss.Left = 365
                TTBoss.Left = 365
                IPBoss.Left = 365
                MMBoss.Left = 365
                TRBoss.Left = 365
                HCChests.Text = 8
                AGChests.Text = 2
                EPChests.Text = 6
                DPChests.Text = 6
                TOHChests.Text = 6
                PODChests.Text = 14
                SPChests.Text = 10
                SWChests.Text = 8
                TTChests.Text = 8
                IPChests.Text = 8
                MMChests.Text = 8
                TRChests.Text = 12
                GTChests.Text = 27
                HCPrizes.Text = 6
                EPPrizes.Text = 3
                DPPrizes.Text = 2
                TOHPrizes.Text = 2
                PODPrizes.Text = 5
                SPPrizes.Text = 6
                SWPrizes.Text = 2
                TTPrizes.Text = 4
                IPPrizes.Text = 3
                MMPrizes.Text = 2
                TRPrizes.Text = 5
            Case 2,5,8,11
                If ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 11 Then
                    SwordButton.Visible = False
                Else 
                    SwordButton.Visible = True
                End If
                HideKeysMap(1)
                EPReward = 0
                DPReward = 0
                TOHReward = 0
                PODReward = 0
                SPReward = 0
                SWReward = 0
                TTReward = 0
                IPReward = 0
                MMReward = 0
                TRReward = 0
                For Each Pic in {EPButton, DPButton, TOHButton, PODButton, SPButton, SWButton, TTButton, IPButton, MMButton, TRButton}
                    Pic.Image = My.Resources.crystal
                Next
                AGBorder.Visible = True
                AGLabel.Visible = True
                AGChests.Visible = True
                AGPrizes.Visible = True
                AGKeys.Visible = False
                EPBoss.Left = 115
                DPBoss.Left = 115
                HeraBoss.Left = 115
                PODBoss.Left = 115
                SPBoss.Left = 115
                SWBoss.Left = 317
                TTBoss.Left = 317
                IPBoss.Left = 317
                MMBoss.Left = 317
                TRBoss.Left = 317
                HCPrizes.Text = 7
                EPPrizes.Text = 3
                DPPrizes.Text = 3
                AGPrizes.Text = 2
                TOHPrizes.Text = 3
                PODPrizes.Text = 11
                SPPrizes.Text = 7
                SWPrizes.Text = 5
                TTPrizes.Text = 5
                IPPrizes.Text = 5
                MMPrizes.Text = 5
                TRPrizes.Text = 9
        End Select
        AllCheck()
    End Sub

    Public Sub LWCheck()
        If (ComboBox1.SelectedIndex < 3) Or ((ComboBox1.SelectedIndex > 5) And (ComboBox1.SelectedIndex < 9)) Then
          LWCheckNormal()
        Else
          LWCheckInverted()
        End If
    End Sub
    
    Public Sub DWCheck()
        If (ComboBox1.SelectedIndex < 3) Or ((ComboBox1.SelectedIndex > 5) And (ComboBox1.SelectedIndex < 9)) Then
          DWCheckNormal()
        Else
          DWCheckInverted()
        End If
    End Sub


    
    Public Sub LWCheckNormal()
        ''Sphere1
        CCLR(LW1)
        CCLR(LW2)
        CCLR(LW7)
        CCLR(LW8)
        CCLR(LW9)
        CCLR(LW11)
        CCLR(LW13)
        CCLR(LW17)
        
        '' Lumberjack Tree - Aganhim and Boots
        If Aganhim And Boots Then
            CCLR(LW6)
        Else
            COFF(LW6)
        End If

        '' Blind Hut, Kakariko Well, Chicken House, Mini-moldorm Cave, Aginah, Ice Cave - Bomb
        If Bombs Then
            CCLR(LW9)
            CCLR(LW10)
            CCLR(LW12)
            CCLR(LW18)
            CCLR(LW19)
            CCLR(LW20)
        Else
            CPCLR(LW9)
            CPCLR(LW10)
            COFF(LW12)
            COFF(LW18)
            COFF(LW19)
            COFF(LW20)
        End If

        '' Sick Kid - Bottle
        If Bottle Then
            CCLR(LW14)
        Else
            COFF(LW14)
        End If

        '' Library, Bonk Rocks - Boots
        If Boots Then
            CCLR(LW15)
            CCLR(LW29)
        Else
            COFF(LW15)
            COFF(LW29)
        End If

        '' Maze Race, Sahasrahla's Back Room - Boots or Bomb
        If Boots Or Bombs Then
            CCLR(LW16)
            CCLR(LW21)
        Else
            COFF(LW16)
            COFF(LW21)
        End If

        '' Desert Ledge - Desert Palace access (Book or Flute/Mitt/Mirror)
        If Book Or (NormalDWMireAcc() And Mirror) Then
            CCLR(LW22)
        Else
            COFF(LW22)
        End If

        '' Bombos Tablet (Swords) - Master Sword, Book, Access via Dark World
        '' Bombos Tablet (Swordless) - Hammer, Book, Access via Dark World
        If Pearl And Mirror And Book And SLcheck(2) And NormalDWMainAcc() Then
            CCLR(LW23)
        Else
            COFF(LW23)
        End If


        '' Checkerboard - Flute, Mitt, Mirror (no Pearl required)
        If Flute And Glove = 2 And Mirror Then
            CCLR(LW24)
        Else
            COFF(LW24)
        End If

        '' Dwarves - Pearl, Mitt (no Mirror required)
        If Pearl And Glove = 2 Then
            CCLR(LW25)
        Else
            COFF(LW25)
        End If

        '' Powder Bat - Powder or Fake-Powder, Hammer or Mirror+Pearl+Mitt
        If Powder And (Hammer Or (Mirror And Pearl And Glove = 2)) Then
            CCLR(LW26)
        ElseIf Mushroom And Somaria And (LW34.Checked = False Or LW26.Checked) And (Hammer Or (Mirror And Pearl And Glove = 2)) Then
            CSQB(LW26)
        Else
            COFF(LW26)
        End If

        '' Dig Spot - Shovel
        If Shovel Then
            CCLR(LW27)
        Else
            COFF(LW27)
        End If

        '' Cave south of Grove, Graveyard Cave - Mirror, Access via Dark World
        If Mirror And Pearl And NormalDWMainAcc() Then
            CCLR(LW28)
            CCLR(LW30)
        Else
            COFF(LW28)
            COFF(LW30)
        End If

        '' King's Tomb - Boots, Mitt or Access via Dark World
        If Boots And (Glove = 2 Or (Mirror And Pearl And NormalDWMainAcc())) Then
            CCLR(LW31)
        Else
            COFF(LW31)
        End If

        '' Hobo, Zora's Ledge, Waterfall - Flippers (Hobo can be faked, Waterfall with waterwalk, Ledge with stored waterwalk)
        If Flippers Then
            CCLR(LW32)
            CCLR(LW35)
            CCLR(LW37)
        Else
            CSQB(LW32)
            If Pearl Or Boots Then
                CSQB(LW35)
            Else
                COFF(LW35)
            End If
            If Pearl And Boots Then
                CSQB(LW37)
            Else
                COFF(LW37)
            End If
        End If

        '' Hylia Island - Flippers, Mirror, Pearl, access via Dark World
        If Pearl And Flippers And Mirror And (NormalDWEastAcc() Or NormalDWMainAcc()) Then
            CCLR(LW33)
        Else
            COFF(LW33)
        End If

        '' Witch - Mushroom
        If Mushroom Then
            CCLR(LW34)
        Else
            COFF(LW34)
        End If

        '' Zora - Glove or Flippers (can be faked)
        If Flippers Or Glove Then
            CCLR(LW36)
        Else
            CSQB(LW36)
        End If

        '' Old Man - Death Mountain access and Lamp (can be dark-navved)
        If NormalLWDMAcc() = 1 Then
            CCLR(LW38)
        ElseIf NormalLWDMAcc() = 2 Then
            CSQB(LW38)
        Else
            COFF(LW38)
        End If

        '' Spectacle Cave - Death Mountain access (Lamp prevents sequence break if Glove is used)
        If NormalLWDMAcc() = 1 Then
            CCLR(LW39)
        ElseIf NormalLWDMAcc() = 2 Then
            CSQB(LW39)
        Else
            COFF(LW39)
        End If

        '' Spectacle Rock - Death Mountain access (Lamp prevents sequence break if Glove is used) and Mirror
        If (Mirror Or (Hammer And Hookshot)) And NormalLWDMAcc() = 1 Then
            CCLR(LW40)
        ElseIf (Mirror Or (Hammer And Hookshot)) And NormalLWDMAcc() = 2 Then
            CSQB(LW40)
        Else
            COFF(LW40)
        End If

        '' Ether Tablet (Swords) - Death Mountain access (Lamp prevents sequence break if Glove is used), Mirror or Hookshot+Hammer, Master Sword, Book
        '' Ether Tablet (SWordless) - Death Mountain access (Lamp prevents sequence break if Glove is used), Mirror or Hookshot, Hammer, Book
        If SLcheck(2) And Book And NormalLWDMAcc() = 1 And (Mirror Or (Hammer And Hookshot)) Then
            CCLR(LW41)
        ElseIf SLcheck(2) And Book And NormalLWDMAcc() = 2 And (Mirror Or (Hammer And Hookshot)) Then
            CSQB(LW41)
        Else
            COFF(LW41)
        End If

        '' East Death Mountain, Spiral Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Hookshot or Mirror+Hammer
        If NormalLWDMAcc() = 1 And (Hookshot Or (Hammer And Mirror)) Then
            If Bombs Then
                CCLR(LW42)
            Else
                CPCLR(LW42)
            End If
            CCLR(LW43)
        ElseIf NormalLWDMAcc() = 2 And (Hookshot Or (Hammer And Mirror)) Then
            If Bombs Then
                CSQB(LW42)
            Else
                CPCLR(LW42)
            End If
            CSQB(LW43)
        Else
            COFF(LW42)
            COFF(LW43)
        End If

        '' Floating Island - Death Mountain access (Lamp prevents sequence break if Glove is used), Mitt, Pearl, Mirror
        If NormalDWDMAcc() And Pearl And Mirror Then
            If Flute Or Lamp Then
                CCLR(LW44)
            Else
                CSQB(LW44)
            End If
        Else
            COFF(LW44)
        End If

        '' Sahasrahla's Green Pendant
        If GreenPendant Then CCLR(LW46) Else COFF(LW46)

        '' Pedestal
        If PendantCount = 3 Then CCLR(LW47) Else COFF(LW47)

        For Each Check as System.Windows.Forms.CheckBox in {LW1, LW2, LW6, LW7, LW8, LW9, LW10, LW11, LW12, LW13, LW14, LW15, LW16, LW17, LW18, LW19, LW20, LW21, LW22, LW23, LW24, LW25, LW26, LW27, LW28, LW29, LW30, LW31, LW32, LW33, LW34, LW35, LW36, LW37, LW38, LW39, LW40, LW41, LW42, LW43, LW44, LW45, LW46, LW47}
            If Check.Checked Then Check.BackColor = Color.FromArgb(64, 64, 64)
        Next

    End Sub
    Public Sub DWCheckNormal()
        '' Pyramid - Aganhim or Access from warp
        If NormalDWEastAcc() Then
            CCLR(DW1)
        Else
            COFF(DW1)
        End If

        '' Chest Game, C House, Sealed Hut, Bumper Cave - Mitt, Glove/Hammer, or Aganhim/Hookshot/Access (Cape and Glove also required for Bumper Cave)
        If Pearl And NormalDWMainAcc() Then
            CCLR(DW2)
            CCLR(DW3)
            CCLR(DW4)
            If Cape And Glove Then
                CCLR(DW7)
            Else
                COFF(DW7)
            End If
        Else
            COFF(DW2)
            COFF(DW3)
            COFF(DW4)
            COFF(DW7)
        End If

        '' Digging Game, Tree Kid, Swamp Hype - Mitt, Glove/Hammer, Aganhim/Hammer, or Aganhim/Hookshot/Glove or Flippers
        If Pearl And NormalDWMainAcc() Then
            CCLR(DW5)
            CCLR(DW10)
            If Bombs Then
                CCLR(DW11)
            Else
                COFF(DW11)
            End If
        Else
            COFF(DW5)
            COFF(DW10)
            COFF(DW11)
        End If

        '' Mire Cave - Flute, Mitt, Pearl
        If NormalDWMireAcc() And Pearl Then
            CCLR(DW6)
        Else
            COFF(DW6)
        End If

        '' Purple Chest - Dwarves complete (no further items required)
        If LW25.Checked Then
            CCLR(DW8)
        Else
            COFF(DW8)
        End If

        '' Hammer Pegs - Pearl, Mitt, Hammer
        If Pearl And Glove = 2 And Hammer Then
            CCLR(DW9)
        Else
            COFF(DW9)
        End If

        '' Catfish - Pearl, Glove, Aganhim/Hammer/Mitt+Flippers
        If Pearl And NormalDWEastAcc() Then
            CCLR(DW12)
        Else
            COFF(DW12)
        End If

        '' Spike Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Hammer, Glove; Safety item (Byrna or Cape) and either 1/2 magic or bottle to avoid sequence break
        If Pearl And Hammer And Glove > 0 And NormalLWDMAcc() And Lamp Then
            If (Byrna Or Cape) And canExtendMagic() Then
                CCLR(DW13)
            Else
                CSQB(DW13)
            End If
        ElseIf Pearl And Hammer And Glove > 0 And NormalLWDMAcc()Then
            CSQB(DW13)
        Else
            COFF(DW13)
        End If

        '' Superbunny Cave - Death Mountain access (Lamp prevents sequence break if Glove is used, Pearl prevents sequence break), Mitt, Hookshot or Hammer+Mirror
        If NormalDWDMAcc() And (Hookshot Or (Hammer and Mirror)) Then
            If (Flute Or Lamp) And Pearl Then
                CCLR(DW14)
            Else
                CSQB(DW14)
            End If
        Else
            COFF(DW14)
        End If

        '' Hookshot Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Mitt, Hookshot or Hammer+Mirror+Boots (Partially blocked without Hookshot)
        If NormalDWDMAcc() And Pearl And Hookshot Then
            If Flute Or Lamp Then
                CCLR(DW15)
            Else
                CSQB(DW15)
            End If
            DW15.TextAlign = ContentAlignment.MiddleCenter
            DW15Boots.Visible = False
        ElseIf NormalDWDMAcc() And Pearl And Boots Then
            COFF(DW1)
            DW15.TextAlign = ContentAlignment.MiddleLeft
            DW15Boots.Visible = True
        Else
            COFF(DW15)
            DW15.TextAlign = ContentAlignment.MiddleCenter
            DW15Boots.Visible = False
        End If

        '' Fat Fairy - Crystals 5 & 6, Pearl, Hammer, Glove or Aganhim
        If Pearl And FairyCrystal = 2 And NormalDWEastAcc() Then
            CCLR(DW16)
        Else
            COFF(DW16)
        End If

        For Each Check as System.Windows.Forms.CheckBox in {DW1, DW2, DW3, DW4, DW5, DW6, DW7, DW8, DW9, DW10, DW11, DW12, DW13, DW14, DW15, DW16}
            If Check.Checked Then Check.BackColor = Color.FromArgb(64, 64, 64)
        Next


    End Sub

    Public Sub LWCheckInverted()

        '' Lumberjack Tree - Aganhim and Boots and LW Access
        If InvertedLWAcc() And Aganhim And Pearl And Boots Then
            CCLR(LW6)
        Else
            COFF(LW6)
        End If
    
        ''Uncle, Mush, Hideout, Dam, Tavern - Pearl and LW Access 
        If Pearl And InvertedLWAcc() Then
            CCLR(LW2)
            CCLR(LW7)
            CCLR(LW8)
            CCLR(LW13)
            CCLR(LW17)
        Else 
            COFF(LW2)
            COFF(LW7)
            COFF(LW8)
            COFF(LW13)
            COFF(LW17)
        End If
        
        '' Blind Hut, Kakariko Well, Chicken House, Mini-moldorm Cave, Aginah, Ice Cave - Bomb, Pearl And LW Access, Part of Well can done as Superbunny
        If InvertedLWAcc() Then
            If Pearl And Bombs Then
                CCLR(LW9)
                CCLR(LW10)
                CCLR(LW11)
                CCLR(LW12)
                CCLR(LW18)
                CCLR(LW19)
                CCLR(LW20)
            ElseIf Pearl Then
                CPCLR(LW9)
                CPCLR(LW10)
                CCLR(LW11)
                COFF(LW12)
                COFF(LW18)
                COFF(LW19)
                COFF(LW20)
            Else
                COFF(LW9)
                CSQB(LW10)
                CCLR(LW11)
                COFF(LW12)
                COFF(LW18)
                COFF(LW19)
                COFF(LW20)
            End If
        Else
            COFF(LW9)
            COFF(LW10)
            COFF(LW11)
            COFF(LW12)
            COFF(LW18)
            COFF(LW19)
            COFF(LW20)
        End If


        '' Sick Kid - Bottle and LW Access
        If Bottle And InvertedLWAcc() Then
            CCLR(LW14)
        Else
            COFF(LW14)
        End If

        '' Library, Bonk Rocks - Boots and Pearl and LW Access
        If Boots And Pearl And InvertedLWAcc() Then
            CCLR(LW15)
            CCLR(LW29)
        Else
            COFF(LW15)
            COFF(LW29)
        End If

        '' Maze Race, Sahasrahla's Back Room - Boots or Bomb and Pearl and LW Access
        If (Boots Or Bombs) And Pearl And InvertedLWAcc() Then
            CCLR(LW16)
            CCLR(LW21)
        Else
            COFF(LW16)
            COFF(LW21)
        End If

        '' Desert Ledge - Desert Palace access (Book and LW Access)
        If Book And Pearl And InvertedLWAcc() Then
            CCLR(LW22)
        ElseIf Book And InvertedLWAcc() Then
            CSQB(LW22)
        Else
            COFF(LW22)
        End If

        '' Bombos Tablet (Swords) - Master Sword, Book, LW Access
        '' Bombos Tablet (Swordless) - Hammer, Book, LW Access
        If Book And SLcheck(2) And InvertedLWAcc() Then
            CCLR(LW23)
        Else
            COFF(LW23)
        End If



        '' Checkerboard - Glove, Pearl, LW Access
        If Pearl And Glove > 0 And InvertedLWAcc() Then
            CCLR(LW24)
        Else
            COFF(LW24)
        End If

        '' Dwarves - Pearl, Mitt (no Mirror required)
        If (Pearl And (Glove = 2 Or (Hammer And Glove > 0 And Mirror))) Or (Aganhim And (Mirror Or Glove = 2)) Then
            CCLR(LW25)
        Else
            COFF(LW25)
        End If

        '' Powder Bat - Powder or Fake-Powder, Hammer or Mirror+Pearl+Mitt
        If Powder And Hammer And Pearl And InvertedLWAcc() Then
            CCLR(LW26)
        ElseIf Mushroom And Somaria And (LW34.Checked = False Or LW26.Checked = True) And Hammer And Pearl And InvertedLWAcc() Then
            CSQB(LW26)
        Else
            COFF(LW26)
        End If

        '' Dig Spot - Shovel
        If Shovel And Pearl And InvertedLWAcc() Then
            CCLR(LW27)
        Else
            COFF(LW27)
        End If

        '' Cave south of Grove, Graveyard Cave - Mirror, Access via Dark World
        If Pearl And InvertedLWAcc() Then
            CCLR(LW28)
            CCLR(LW30)
        Else
            COFF(LW28)
            COFF(LW30)
        End If

        '' King's Tomb - Boots, Mitt or Access via Dark World
        If Boots And Glove = 2 And Pearl And InvertedLWAcc()  Then
            CCLR(LW31)
        Else
            COFF(LW31)
        End If

        '' Hobo, Zora's Ledge, Waterfall - Flippers (Hobo can be faked, Waterfall with waterwalk, Ledge with stored waterwalk)
        If Flippers And Pearl And InvertedLWAcc() Then
            CCLR(LW32)
            CCLR(LW35)
            CCLR(LW37)
        Else
            
            If Pearl And InvertedLWAcc() Then
                CSQB(LW32)
                CSQB(LW35)
            Else
                COFF(LW32)
                COFF(LW35)
            End If
            If Pearl And Boots And InvertedLWAcc() Then
                CSQB(LW37)
            Else
                COFF(LW37)
            End If
        End If

        '' Hylia Island - Flippers, Mirror, Pearl, access via Dark World
        If Flippers And Pearl And InvertedLWAcc() Then
            CCLR(LW33)
        ElseIf Pearl And InvertedLWAcc() Then
            CSQB(LW33)
        Else
            COFF(LW33)
        End If

        '' Witch - Mushroom
        If Mushroom And Pearl And InvertedLWAcc() Then
            CCLR(LW34)
        Else
            COFF(LW34)
        End If

        '' Zora - Glove or Flippers (can be faked)
        If Pearl And (Flippers Or Glove) And InvertedLWAcc() Then
            CCLR(LW36)
        ElseIf Pearl And InvertedLWAcc() Then
            CSQB(LW36)
        Else
            COFF(LW36)
        End If

        '' Old Man - Death Mountain access and Lamp (can be dark-navved)
        If Glove Or (Flute And Pearl And Aganhim) Then
            If Lamp Then
                CCLR(LW38)
            Else
                CSQB(LW38)
            End If
        Else
            COFF(LW38)
        End If

        '' Spectacle Cave - Death Mountain access (Lamp prevents sequence break if Glove is used)
        If (Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc()) Then
            CCLR(LW39)
        ElseIf Glove Or (Flute And Pearl And InvertedLWAcc()) Then
            CSQB(LW39)
        Else
           COFF(LW39)
        End If

        '' Spectacle Rock - Death Mountain access (Lamp prevents sequence break if Glove is used) and Mirror
        If Pearl And Hammer And (Glove = 2 Or Hookshot) And ((Glove > 0 And Lamp) Or (Flute And InvertedLWAcc())) Then
            CCLR(LW40)
        ElseIf Pearl And Hammer And (Glove = 2 Or Hookshot) And (Glove Or (Flute And InvertedLWAcc())) Then
            CSQB(LW40)
        Else
            COFF(LW40)
        End If

        '' Ether Tablet (Swords) - Death Mountain access (Lamp prevents sequence break if Glove is used), Mirror or Hookshot+Hammer, Master Sword, Book
        '' Ether Tablet (SWordless) - Death Mountain access (Lamp prevents sequence break if Glove is used), Mirror or Hookshot, Hammer, Book
        
        If Book And SLcheck(2) And Pearl And Hammer And (Glove = 2 Or Hookshot) And ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) Then
            CCLR(LW41)
        ElseIf Book And SLcheck(2) And Pearl And Hammer And (Glove = 2 Or Hookshot) And Glove Then
            CCLR(LW41)
        Else
            COFF(LW41)
        End If
        

        '' East Death Mountain, Spiral Cave, Floating Island, Mimic Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Hookshot or Mirror+Hammer
        If (Glove = 2 Or (Hookshot And Pearl)) And ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) Then
            If Pearl Then
                If Bombs Then
                    CCLR(LW42)
                Else
                    CPCLR(LW42)
                End If
                If Pearl And Hammer Then
                    CCLR(LW45)
                End If
                CCLR(LW43)
            Else   
                COFF(LW42)
                CSQB(LW43)
                COFF(LW45)
            End IF
            CCLR(LW44)
        ElseIf (Glove = 2 Or (Hookshot And Pearl)) And Glove Then
            If Pearl Then
                If Bombs Then
                    CSQB(LW42)
                Else
                    CPCLR(LW42)
                End If
                If Pearl And Hammer Then
                    CSQB(LW45)
                End If
                CSQB(LW43)
                
            End If
            CSQB(LW44)
        Else
            COFF(LW42)
            COFF(LW43)
            COFF(LW44)
            COFF(LW45)
        End If

        '' Sahasrahla's Green Pendant
        If GreenPendant And InvertedLWAcc() Then CCLR(LW46) Else COFF(LW46)
        
        '' Pedestal
        If PendantCount = 3 And InvertedLWAcc() Then CCLR(LW47) Else COFF(LW47)
                
        For Each Check as System.Windows.Forms.CheckBox in {LW1, LW2, LW6, LW7, LW8, LW9, LW10, LW11, LW12, LW13, LW14, LW15, LW16, LW17, LW18, LW19, LW20, LW21, LW22, LW23, LW24, LW25, LW26, LW27, LW28, LW29, LW30, LW31, LW32, LW33, LW34, LW35, LW36, LW37, LW38, LW39, LW40, LW41, LW42, LW43, LW44, LW45, LW46, LW47}
            If Check.Checked Then Check.BackColor = Color.FromArgb(64, 64, 64)
        Next

    End Sub
    Public Sub DWCheckInverted()
        '' Pyramid - Hammer/Flipper/LW+(Mirror or Flute)
        If Hammer Or Flippers Or (Mirror And InvertedLWAcc()) Or (Flute And Pearl And InvertedLWAcc()) Then
            CCLR(DW1)
        Else
            COFF(DW1)
        End If

        '' Chest Game, C House, Sealed Hut - Free, just walk there
        CCLR(DW2)
        CCLR(DW3)
        If Bombs Then
            CCLR(DW4)
        Else
            COFF(DW4)
        End If

        '' Digging Game, Tree Kid, Hype Cape - Free, just walk there
        CCLR(DW5)
        CCLR(DW10)
        If Bombs Then
            CCLR(DW11)
        Else
            COFF(DW11)
        End If


        '' Mire Cave - LW Access+(Mirror Or Flute+Pearl)
        If InvertedLWAcc() And (Mirror Or (Flute And Pearl)) Then
            CCLR(DW6)
        Else
            COFF(DW6)
        End If

        ''Bumper Cave - LW Access+Cape+Glove+Mirror
        If InvertedLWAcc() And Pearl And Glove > 0 And Cape And Mirror Then
            CCLR(DW7)
        Else
            COFF(DW7)
        End If
        
        '' Purple Chest - Dwarves complete (no further items required)
        If LW25.Checked Then
            CCLR(DW8)
        Else
            COFF(DW8)
        End If

        '' Hammer Pegs - Hammer, Mitts or LW+Mirror
        If Hammer And ((Glove = 2) Or (Mirror And InvertedLWAcc())) Then
            CCLR(DW9)
        Else
            COFF(DW9)
        End If

        '' Catfish - Glove > 0 And Flipps/Hammer/LW+(Mirror/Flute+Pearl)
        If Glove > 0 And (Hammer Or Flippers Or (InvertedLWAcc() And (Mirror Or (Flute And Pearl)))) Then
            CCLR(DW12)
        Else
            COFF(DW12)
        End If

        '' Spike Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Hammer, Glove; Safety item (Byrna or Cape) and either 1/2 magic or bottle to avoid sequence break
        If Hammer And Glove > 0 And (Lamp Or (Flute And Pearl And InvertedLWAcc())) Then
            If (Byrna Or Cape) And canExtendMagic()  Then
                CCLR(DW13)
            Else
                CSQB(DW13)
            End If
        ElseIf Hammer And Glove > 0 And (Flute And Pearl And InvertedLWAcc()) Then
            CSQB(DW13)
        Else
            COFF(DW13)
        End If

        '' Superbunny Cave - Death Mountain access (Lamp prevents sequence break if Glove is used, Pearl prevents sequence break), Mitt, Hookshot or Hammer+Mirror
        If (Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc()) Then
            CCLR(DW14)
        ElseIf Glove Then
            CSQB(DW14)
        Else
            COFF(DW14)
        End If

        '' Hookshot Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Mitt, Hookshot or Hammer+Mirror+Boots (Partially blocked without Hookshot)
        If Hookshot And ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) Then
           CCLR(DW15)
           DW15.TextAlign = ContentAlignment.MiddleCenter
           DW15Boots.Visible = False
        ElseIf Hookshot And Glove Then
           CSQB(DW15)
           DW15.TextAlign = ContentAlignment.MiddleCenter
           DW15Boots.Visible = False
        ElseIf Boots And ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) Then
            COFF(DW15)
            DW15.TextAlign = ContentAlignment.MiddleLeft
            DW15Boots.BackColor = Color.WhiteSmoke
            DW15Boots.Visible = True
        ElseIf Boots And Glove > 0 Then
            COFF(DW15)
            DW15.TextAlign = ContentAlignment.MiddleLeft
            DW15Boots.BackColor = Color.Orange
            DW15Boots.Visible = True
        Else
            COFF(DW15)
            DW15.TextAlign = ContentAlignment.MiddleCenter
            DW15Boots.Visible = False
        End If

        '' Fat Fairy - Crystals 5 & 6, Pearl, Hammer, Glove or Aganhim
        If Mirror And FairyCrystal = 2 And InvertedLWAcc() Then
            CCLR(DW16)
        Else
            COFF(DW16)
        End If

        For Each Check as System.Windows.Forms.CheckBox in {DW1, DW2, DW3, DW4, DW5, DW6, DW7, DW8, DW9, DW10, DW11, DW12, DW13, DW14, DW15, DW16}
            If Check.Checked Then Check.BackColor = Color.FromArgb(64, 64, 64)
        Next

    End Sub

    Private Sub LocationClick(sender As Object, e As EventArgs) Handles LW1.CheckedChanged, LW2.CheckedChanged, LW6.CheckedChanged, LW7.CheckedChanged, LW8.CheckedChanged, LW9.CheckedChanged, LW10.CheckedChanged, LW11.CheckedChanged, LW12.CheckedChanged, LW13.CheckedChanged, LW14.CheckedChanged, LW15.CheckedChanged, LW16.CheckedChanged,
        LW17.CheckedChanged, LW18.CheckedChanged, LW19.CheckedChanged, LW20.CheckedChanged, LW21.CheckedChanged, LW22.CheckedChanged, LW23.CheckedChanged, LW24.CheckedChanged, LW25.CheckedChanged, LW26.CheckedChanged, LW27.CheckedChanged, LW28.CheckedChanged, LW29.CheckedChanged, LW30.CheckedChanged, LW31.CheckedChanged, LW32.CheckedChanged,
        LW33.CheckedChanged, LW34.CheckedChanged, LW35.CheckedChanged, LW36.CheckedChanged, LW37.CheckedChanged, LW38.CheckedChanged, LW39.CheckedChanged, LW40.CheckedChanged, LW41.CheckedChanged, LW42.CheckedChanged, LW43.CheckedChanged, LW44.CheckedChanged, LW45.CheckedChanged, LW46.CheckedChanged, LW47.CheckedChanged, DW1.CheckedChanged,
        DW2.CheckedChanged, DW3.CheckedChanged, DW4.CheckedChanged, DW5.CheckedChanged, DW6.CheckedChanged, DW7.CheckedChanged, DW8.CheckedChanged, DW9.CheckedChanged, DW10.CheckedChanged, DW11.CheckedChanged, DW12.CheckedChanged, DW13.CheckedChanged, DW14.CheckedChanged, DW15.CheckedChanged, DW16.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then DirectCast(sender, CheckBox).BackColor = Color.FromArgb(64, 64, 64) Else DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
        LWCheck()
        DWCheck()
    End Sub

    Private Sub SwitchChestIcon(sender As Object, e As EventArgs, Val As Integer)
        Select Case Val
            Case 1
                DirectCast(sender, Button).Image = My.Resources.redchestsmall
            Case 2
                DirectCast(sender, Button).Image = My.Resources.greenchestsmall
            Case Else
                DirectCast(sender, Button).Image = My.Resources.chestmaybesmall
        End Select
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgaTree = (AgaTree + 1) Mod 3
        SwitchChestIcon(sender, e, AgaTree)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Library = (Library + 1) Mod 3
        SwitchChestIcon(sender, e, Library)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Maze = (Maze + 1) Mod 3
        SwitchChestIcon(sender, e, Maze)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SpecRock = (SpecRock + 1) Mod 3
        SwitchChestIcon(sender, e, SpecRock)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EtherTab = (EtherTab + 1) Mod 3
        SwitchChestIcon(sender, e, EtherTab)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Floating = (Floating + 1) Mod 3
        SwitchChestIcon(sender, e, Floating)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DPLedge = (DPLedge + 1) Mod 3
        SwitchChestIcon(sender, e, DPLedge)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BombosTab = (BombosTab + 1) Mod 3
        SwitchChestIcon(sender, e, BombosTab)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ZoraLedge = (ZoraLedge + 1) Mod 3
        SwitchChestIcon(sender, e, ZoraLedge)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        LakeIsle = (LakeIsle + 1) Mod 3
        SwitchChestIcon(sender, e, LakeIsle)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Pedestal = (Pedestal + 1) Mod 3
        SwitchChestIcon(sender, e, Pedestal)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Bumper = (Bumper + 1) Mod 3
        SwitchChestIcon(sender, e, Bumper)
    End Sub

    Public Sub HCCheck()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If Glove > 0 And Lamp And (Bombs Or Boots) Then
                LCLR(HCLabel)
                LChests(HCChests,8,Color.White)
                HCBorder.BackColor = Color.White
            ElseIf Lamp And (Bombs Or Boots) Then
                LPCLR(HCLabel)
                LChests(HCChests,8,Color.Yellow)
                HCBorder.BackColor = Color.Black
            ElseIf Glove > 0 And (Bombs Or Boots) Then
                LPCLR(HCLabel)
                LChests(HCChests,8,Color.Orange)
                HCBorder.BackColor = Color.Black
            ElseIf Lamp Then
                LPCLR(HCLabel)
                LChests(HCChests,5,Color.White)
                HCBorder.BackColor = Color.Black
            Else
                LPCLR(HCLabel)
                LChests(HCChests,5,Color.Yellow)
                HCBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 7 Then
            If (Glove > 0 Or HCKeys.Text = 1) And (Bombs Or Boots) Then
                If Lamp Then LCLR(HCLabel) Else LSQB(HCLabel)
                HCBorder.BackColor = Color.White
            Else
                LPCLR(HCLabel)
                HCBorder.BackColor = Color.Black
            End If
		ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If Pearl And InvertedLWAcc() And Glove > 0 And Lamp And (Bombs Or Boots) Then
                LCLR(HCLabel)
                LChests(HCChests,8,Color.White)
                HCBorder.BackColor = Color.White
            ElseIf Pearl And InvertedLWAcc() And Lamp And (Bombs Or Boots) Then
                LPCLR(HCLabel)
                LChests(HCChests,8,Color.Yellow)
                HCBorder.BackColor = Color.Black
            ElseIf Pearl And InvertedLWAcc() And Glove > 0 And (Bombs Or Boots) Then
                LSQB(HCLabel)
                LChests(HCChests,8,Color.Orange)
                HCBorder.BackColor = Color.White
            ElseIf Pearl And InvertedLWAcc() Then
                LPCLR(HCLabel)
                LChests(HCChests,5,Color.White)
                HCBorder.BackColor = Color.Black
            Else
                LOFF(HCLabel)
                LChests(HCChests,5,Color.White)
                HCBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If Pearl And InvertedLWAcc() And (Glove > 0 Or HCKeys.Text = 1) And (Bombs Or Boots) Then
                If Lamp Then LCLR(HCLabel) Else LSQB(HCLabel)
                HCChests.ForeColor = Color.White
                HCBorder.BackColor = Color.White
            ElseIf Pearl And InvertedLWAcc()
                LPCLR(HCLabel)
                HCBorder.BackColor = Color.Black
            Else
                LOFF(HCLabel)
                HCBorder.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub HCChests_MouseDown(sender As Object, e As EventArgs) Handles HCChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
            If MouseButtons = MouseButtons.Left Then NumChange(HCChests,8,-1,1)
            If MouseButtons = MouseButtons.Right Then NumChange(HCChests,8,1,1)
        End If
    End Sub

    Private Sub HCKeys_MouseDown(sender As Object, e As EventArgs) Handles HCKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(HCKeys,1,1)
        If MouseButtons = MouseButtons.Right Then NumChange(HCKeys,1,-1)
        HCCheck()
        LWCheck()
    End Sub

    Private Sub HCPrizes_MouseDown(sender As Object, e As EventArgs) Handles HCPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 And ComboBox1.SelectedIndex <> 7 And ComboBox1.SelectedIndex <> 10 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(HCPrizes,6,-1,1)
            End If
            If MouseButtons = MouseButtons.Right Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 9 Then
                    NumChange(HCPrizes,6,1,1)
                Else
                    NumChange(HCPrizes,7,1,1)
                End If
            End If
        End If
    End Sub

    Private Sub AGChests_MouseDown(sender As Object, e As MouseEventArgs) Handles AGChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
            If MouseButtons = MouseButtons.Left Then NumChange(AGChests,2,-1,1)
            If MouseButtons = MouseButtons.Right Then NumChange(AGChests,2,1,1)
        End If
    End Sub

    Private Sub EPClick(sender As Object, e As EventArgs) Handles EPMap.CheckedChanged, EPBigKey.CheckedChanged, EPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "EPMap"
                If EPMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If EPReward = -1 Then EPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "EPBigKey"
                If EPBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    EPBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    EPBigKey.BackColor = Color.Red
                End If
            Case "EPBoss"
                If EPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    EPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    EPButton.BackColor = Color.Black
                End If
        End Select
        EPCheck()
        CrystalCheck()
    End Sub

    Private Sub EPChests_MouseDown(sender As Object, e As EventArgs) Handles EPChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(EPChests,6,-1,1)
                If EPChests.Text = 0 Then EPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                NumChange(EPChests,6,1,1)
                EPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub EPPrizes_MouseDown(sender As Object, e As EventArgs) Handles EPPrizes.MouseDown
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(EPPrizes,3,-1,1)
                If EPPrizes.Text = 0 Then EPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                NumChange(EPPrizes,3,1,1)
                EPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Public Sub EPCheck()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If Bow > 1 Then
                EPBoss.Enabled = True
                If Lamp Then
                    LCLR(EPLabel)
                    LChests(EPChests,6,Color.White)
                    EPBorder.BackColor = Color.White
                Else
                    LSQB(EPLabel)
                    LChests(EPChests,6,Color.Orange)
                    EPBorder.BackColor = Color.White
                End If
            Else
                LPCLR(EPLabel)
                EPBorder.BackColor = Color.Black
                EPBoss.Enabled = False
                If Lamp Then LChests(EPChests,5,Color.White) Else LChests(EPChests,5,Color.Orange)
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If Bow > 1 And Pearl And InvertedLWAcc() Then
                EPBoss.Enabled = True
                If Lamp Then
                    LCLR(EPLabel)
                    LChests(EPChests,6,Color.White)
                    EPBorder.BackColor = Color.White
                Else
                    LSQB(EPLabel)
                    LChests(EPChests,6,Color.Orange)
                    EPBorder.BackColor = Color.White
                End If
            ElseIf Pearl And InvertedLWAcc() Then
                    LPCLR(EPLabel)
                    LChests(EPChests,5,Color.Orange)
                    EPBorder.BackColor = Color.Black                
            Else
                LOFF(EPLabel)
                EPBorder.BackColor = Color.Black
                EPBoss.Enabled = False
                LChests(EPChests,0,Color.White)
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 7 Then
            If Bow > 1 And Lamp And EPBigKey.Checked Then
                LCLR(EPLabel)
                EPBoss.Enabled = True
                EPChests.ForeColor = Color.White
                EPBorder.BackColor = Color.White
            ElseIf Bow > 1 And EPBigKey.Checked Then
                LSQB(EPLabel)
                EPBoss.Enabled = True
                EPChests.ForeColor = Color.White
                EPBorder.BackColor = Color.White
            Else
                LPCLR(EPLabel)
                EPBoss.Enabled = False
                EPChests.ForeColor = Color.White
                EPBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If Bow > 1 And Lamp And Pearl And InvertedLWAcc() And EPBigKey.Checked Then
                LCLR(EPLabel)
                EPBoss.Enabled = True
                EPChests.ForeColor = Color.White
                EPBorder.BackColor = Color.White
            ElseIf Bow > 1 And EPBigKey.Checked Then
                LSQB(EPLabel)
                EPBoss.Enabled = True
                EPChests.ForeColor = Color.White
                EPBorder.BackColor = Color.White
            ElseIf Pearl And InvertedLWAcc() Then
                LPCLR(EPLabel)
                EPBoss.Enabled = False
                EPChests.ForeColor = Color.White
                EPBorder.BackColor = Color.Black
            Else
                LOFF(EPLabel)
                EPBoss.Enabled = False
                EPBorder.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub DPClick(sender As Object, e As EventArgs) Handles DPMap.CheckedChanged, DPBigKey.CheckedChanged, DPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "DPMap"
                If DPMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If DPReward = -1 Then DPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "DPBigKey"
                If DPBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    DPBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    DPBigKey.BackColor = Color.Red
                End If
            Case "DPBoss"
                If DPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    DPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    DPButton.BackColor = Color.Black
                End If
        End Select
        DPCheck()
        CrystalCheck()
    End Sub
    Private Sub DPChests_MouseDown(sender As Object, e As EventArgs) Handles DPChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(DPChests,6,-1,1)
                If DPChests.Text = 0 Then DPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                NumChange(DPChests,6,1,1)
                DPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub DPPrizes_MouseDown(sender As Object, e As EventArgs) Handles DPPrizes.MouseDown
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(DPPrizes,3,-1,1)
                If DPPrizes.Text = 0 Then DPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 9 Then
                    NumChange(DPPrizes,2,1,1)
                Else
                    NumChange(DPPrizes,3,1,1)
                End If
                DPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub DPKeys_MouseDown(sender As Object, e As EventArgs) Handles DPKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(DPKeys,1,1)
        If MouseButtons = MouseButtons.Right Then NumChange(DPKeys,1,-1)
        DPCheck()
    End Sub

    Public Sub DPCheck()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If (Book Or (Glove = 2 And Flute And Mirror)) And (FireRod Or Lamp) And Boots And Glove > 0 Then
                LCLR(DPLabel)
                LChests(DPChests,6,Color.White)
                DPBorder.BackColor = Color.White
                DPBoss.Enabled = True
            ElseIf (Book Or (Glove = 2 And Flute And Mirror)) And (FireRod Or Lamp) And Glove > 0 Then
                LPCLR(DPLabel)
                LChests(DPChests,5,Color.Yellow)
                DPBorder.BackColor = Color.Black
                DPBoss.Enabled = True
            ElseIf (Book Or (Glove = 2 And Flute And Mirror)) Then
                LPCLR(DPLabel)
                LChests(DPChests,4,Color.Yellow)
                DPBorder.BackColor = Color.Black
                DPBoss.Enabled = False
            Else
                LOFF(DPLabel)
                LChests(DPChests,0,Color.White)
                DPBorder.BackColor = Color.Black
                DPBoss.Enabled = False
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
            If (Book Or (Glove = 2 And Flute And Mirror)) And (FireRod Or Lamp) And Glove > 0 And DPBigKey.Checked = True Then
                If DPKeys.Text = 1 Then LCLR(DPLabel) Else LSQB(DPLabel)
                DPBoss.Enabled = True
                DPBorder.BackColor = Color.White
            ElseIf (Book Or (Glove = 2 And Flute And Mirror)) And (FireRod Or Lamp) And Glove > 0 And DPBigKey.Checked = True Then
                LPCLR(DPLabel)
                DPBoss.Enabled = True
                DPBorder.BackColor = Color.Black
            ElseIf (Book Or (Glove = 2 And Flute = True And Mirror)) Then
                LPCLR(DPLabel)
                DPBoss.Enabled = False
                DPBorder.BackColor = Color.Black
            Else
                LOFF(DPLabel)
                DPBoss.Enabled = False
                DPBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If Book And Pearl And InvertedLWAcc() And (FireRod Or Lamp) And Boots And Glove > 0 Then
                LCLR(DPLabel)
                LChests(DPChests,6,Color.White)
                DPBorder.BackColor = Color.White
                DPBoss.Enabled = True
            ElseIf Book And Pearl And InvertedLWAcc() And (FireRod Or Lamp) And Glove > 0 Then
                LPCLR(DPLabel)
                LChests(DPChests,5,Color.Yellow)
                DPBorder.BackColor = Color.Black
                DPBoss.Enabled = True
            ElseIf Book And Pearl And InvertedLWAcc() Then
                LPCLR(DPLabel)
                LChests(DPChests,4,Color.Yellow)
                DPBorder.BackColor = Color.Black
                DPBoss.Enabled = False
            Else
                LOFF(DPLabel)
                LChests(DPChests,0,Color.White)
                DPBorder.BackColor = Color.Black
                DPBoss.Enabled = False
            End If
      ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Then
            If Book And Pearl And InvertedLWAcc() And (FireRod Or Lamp) And Glove > 0 And DPBigKey.Checked = True Then
                If DPKeys.Text = 1 Then LCLR(DPLabel) Else LSQB(DPLabel)
                DPBoss.Enabled = True
                DPBorder.BackColor = Color.White
            ElseIf Book And Pearl And InvertedLWAcc() And (FireRod Or Lamp) And Glove > 0 And DPBigKey.Checked = True Then
                LPCLR(DPLabel)
                DPBoss.Enabled = True
                DPBorder.BackColor = Color.Black
            ElseIf Book And Pearl And InvertedLWAcc() Then
                LPCLR(DPLabel)
                DPBoss.Enabled = False
                DPBorder.BackColor = Color.Black
            Else
                LOFF(DPLabel)
                DPBoss.Enabled = False
                DPBorder.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TOHClick(sender As Object, e As EventArgs) Handles HeraMap.CheckedChanged, HeraBigKey.CheckedChanged, HeraBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "HeraMap"
                If HeraMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If TOHReward = -1 Then TOHButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "HeraBigKey"
                If HeraBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    HeraBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    HeraBigKey.BackColor = Color.Red
                End If
            Case "HeraBoss"
                If HeraBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    TOHButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    TOHButton.BackColor = Color.Black
                End If
        End Select
        TOHCheck()
        CrystalCheck()
    End Sub
    Private Sub TOHChests_MouseDown(sender As Object, e As EventArgs) Handles TOHChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(TOHChests,6,-1,1)
                If TOHChests.Text = 0 Then TOHLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                NumChange(TOHChests,6,1,1)
				TOHLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TOHPrizes_MouseDown(sender As Object, e As EventArgs) Handles TOHPrizes.MouseDown
       If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(TOHPrizes,3,-1,1)
                If TOHPrizes.Text = 0 Then TOHLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 9 Then
                    NumChange(TOHPrizes,2,1,1)
                Else
                    NumChange(TOHPrizes,3,1,1)
                End If
                TOHLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub HeraKeys_MouseDown(sender As Object, e As EventArgs) Handles TOHKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(TOHKeys,1,1)
        If MouseButtons = MouseButtons.Right Then NumChange(TOHKeys,1,-1)
		TOHCheck()
    End Sub
    Public Sub TOHCheck()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Then
            If (Glove > 0 Or Flute) And (Mirror Or (Hammer And Hookshot)) And (Sword > 0 Or Hammer) And (Lamp Or FireRod) And (Sword > 0 Or Hammer) Then
                HeraBoss.Enabled = True
                If Flute Or Lamp Then LCLR(TOHLabel) Else LSQB(TOHLabel)
                LChests(TOHChests,6,Color.White)
                TOHBorder.BackColor = Color.White
            ElseIf (Glove > 0 Or Flute) And (Mirror Or (Hammer And Hookshot)) And (Sword > 0 Or Hammer) Then
                LPCLR(TOHLabel)
                HeraBoss.Enabled = True
                LChests(TOHChests,5,Color.Yellow)
                TOHBorder.BackColor = Color.Black
            ElseIf (Glove > 0 Or Flute) And (Mirror Or (Hammer And Hookshot)) Then
                LPCLR(TOHLabel)
                HeraBoss.Enabled = False
                LChests(TOHChests,4,Color.Yellow)
                TOHBorder.BackColor = Color.Black
            Else
                LOFF(TOHLabel)
                HeraBoss.Enabled = False
                LChests(TOHChests,0,Color.White)
                TOHBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Then
            If (Glove > 0 Or Flute) And (Mirror Or (Hammer And Hookshot)) And (Sword > 0 Or Hammer) And HeraBigKey.Checked = True Then
                HeraBoss.Enabled = True
                If Flute Or Lamp Then LCLR(TOHLabel) Else LSQB(TOHLabel)
                TOHBorder.BackColor = Color.White
            ElseIf (Flute Or Glove > 0) And (Mirror Or (Hammer And Hookshot)) Then
                LPCLR(TOHLabel)
                HeraBoss.Enabled = False
                TOHBorder.BackColor = Color.Black
            Else
                LOFF(TOHLabel)
                HeraBoss.Enabled = False
                TOHBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If (Glove > 0 Or Flute) And (Mirror Or Hookshot) And Hammer And (Lamp Or FireRod) Then
                HeraBoss.Enabled = True
                If Flute Or Lamp Then LCLR(TOHLabel) Else LSQB(TOHLabel)
                LChests(TOHChests,6,Color.White)
                TOHBorder.BackColor = Color.White
            ElseIf (Glove > 0 Or Flute) And (Mirror Or (Hammer And Hookshot)) And Hammer Then
                LPCLR(TOHLabel)
                HeraBoss.Enabled = True
                LChests(TOHChests,5,Color.Yellow)
                TOHBorder.BackColor = Color.Black
            ElseIf (Glove > 0 Or Flute) And (Mirror Or (Hammer And Hookshot)) Then
                LPCLR(TOHLabel)
                HeraBoss.Enabled = False
                LChests(TOHChests,4,Color.Yellow)
                TOHBorder.BackColor = Color.Black
            Else
                LOFF(TOHLabel)
                HeraBoss.Enabled = False
                LChests(TOHChests,0,Color.White)
                TOHBorder.BackColor = Color.Black
            End If
            ElseIf ComboBox1.SelectedIndex = 7 Then
            If (Glove > 0 Or Flute) And Hammer And (Mirror Or Hookshot) And HeraBigKey.Checked = True Then
                TOHLabel.ForeColor = Color.White
                HeraBoss.Enabled = True
                If Flute Or Lamp Then LCLR(TOHLabel) Else LSQB(TOHLabel)
                TOHBorder.BackColor = Color.White
            ElseIf (Flute Or Glove > 0) And (Mirror Or (Hammer And Hookshot)) Then
                LPCLR(TOHLabel)
                HeraBoss.Enabled = False
                TOHBorder.BackColor = Color.Black
            Else
                LOFF(TOHLabel)
                HeraBoss.Enabled = False
                TOHBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If Pearl And Hammer And (Lamp Or FireRod) And (Glove = 2 Or Hookshot) And ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) Then
                LCLR(TOHLabel)
                HeraBoss.Enabled = True
                LChests(TOHChests,6,Color.White)
                TOHBorder.BackColor = Color.White
            ElseIf Pearl And Hammer And (Glove = 2 Or Hookshot) And ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) Then
                LPCLR(TOHLabel)
                HeraBoss.Enabled = True
                LChests(TOHChests,5,Color.Yellow)
                TOHBorder.BackColor = Color.Black
            ElseIf Pearl And Hammer And (Glove = 2 Or Hookshot) And (Glove > 0 Or (Flute And Pearl And InvertedLWAcc())) Then
                LSQB(TOHLabel)
                HeraBoss.Enabled = True
                LChests(TOHChests,5,Color.Yellow)
                TOHBorder.BackColor = Color.Black
            Else
                LOFF(TOHLabel)
                HeraBoss.Enabled = False
                LChests(TOHChests,0,Color.White)
                TOHBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If Pearl And Hammer And (Lamp Or FireRod) And (Glove = 2 Or Hookshot) And ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) And HeraBigKey.Checked = True Then
                LCLR(TOHLabel)
                HeraBoss.Enabled = True
                TOHBorder.BackColor = Color.White
            ElseIf Pearl And Hammer And (Glove = 2 Or Hookshot) And (Glove > 0 Or (Flute And Pearl And InvertedLWAcc())) Then
                LPCLR(TOHLabel)
                HeraBoss.Enabled = False
                TOHBorder.BackColor = Color.Black
            Else
                LOFF(TOHLabel)
                HeraBoss.Enabled = False
                TOHBorder.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub AGPrizes_MouseDown(sender As Object, e As EventArgs) Handles AGPrizes.MouseDown
        If ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 11 Then
            If MouseButtons = MouseButtons.Left Then NumChange(AGPrizes,2,-1,1)
            If MouseButtons = MouseButtons.Right Then NumChange(AGPrizes,2,1,1)
        End If
    End Sub

    Private Sub AGKeys_MouseDown(sender As Object, e As EventArgs) Handles AGKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(AGKeys,2,1)
        If MouseButtons = MouseButtons.Right Then NumChange(AGKeys,2,-1)
        AgaCheck()
    End Sub

    Public Sub AgaCheck()
        Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })
        Dim noaganhim As New Bitmap(My.Resources.aganhim)
        Dim imgattr As New Imaging.ImageAttributes()
        imgattr.SetColorMatrix(grayscale)
        Using g As Graphics = Graphics.FromImage(noaganhim)
            g.DrawImage(noaganhim, New Rectangle(0, 0, noaganhim.Width, noaganhim.Height),
                    0, 0, noaganhim.Width, noaganhim.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If (SLcheck(2) Or (Cape And SLcheck(1)) Or (Cape And SLcheck(1,0) And Net)) And Lamp Then
                AgaButton.Visible = True
                If Aganhim = False Then AgaButton.Image = noaganhim
                LCLR(AGLabel)
                AGBorder.BackColor = Color.White
                LChests(AGChests,2,Color.White)
            Else
                AgaButton.Visible = False
                LOFF(AGLabel)
                AGBorder.BackColor = Color.Black
                LChests(AGChests,0,Color.White) 
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 7 Then
            If (SLcheck(2) Or (Cape And SLcheck(1)) Or (Cape And SLcheck(1,0) And Net)) And Lamp And AGKeys.Text = 2 Then
                AgaButton.Visible = True
                If Aganhim = False Then AgaButton.Image = noaganhim
                LCLR(AGLabel)
                AGBorder.BackColor = Color.White
            ElseIf SLcheck(2) Or Cape Then
                AgaButton.Visible = False
                LPCLR(AGLabel)
                AGBorder.BackColor = Color.Black
            Else
                AgaButton.Visible = False
                LOFF(AGLabel)
                AGBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If (SLcheck(1) Or (SLcheck(1,0) And Net)) And Glove > 0 And Lamp Then
                AgaButton.Visible = True
                If Aganhim = False Then AgaButton.Image = noaganhim
                LCLR(AGLabel)
                AGBorder.BackColor = Color.White
                LChests(AGChests,2,Color.White)         
            ElseIf Glove > 0 And Lamp Then
                AgaButton.Visible = False
                LPCLR(AGLabel)
                AGBorder.BackColor = Color.Black
                LChests(AGChests,2,Color.White)
            Else
                AgaButton.Visible = False
                LOFF(AGLabel)
                LChests(AGChests,0,Color.White)
                AGBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If (SLcheck(1) Or (SLcheck(1,0) And Net)) And Glove > 0 And Lamp And AGKeys.Text = 2 Then
                AgaButton.Visible = True
                If Aganhim = False Then AgaButton.Image = noaganhim
                LCLR(AGLabel)
                AGBorder.BackColor = Color.White
            ElseIf Glove > 0 And Lamp Then
                AgaButton.Visible = False
                LPCLR(AGLabel)
                AGBorder.BackColor = Color.Black
            Else
                AgaButton.Visible = False
                LOFF(AGLabel)
                AGBorder.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub PODClick(sender As Object, e As EventArgs) Handles PODMap.CheckedChanged, PODBigKey.CheckedChanged, PODBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "PODMap"
                If PODMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If PODReward = -1 Then PODButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "PODBigKey"
                If PODBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    PODBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    PODBigKey.BackColor = Color.Red
                End If
            Case "PODBoss"
                If PODBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    PODButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    PODButton.BackColor = Color.Black
                End If
        End Select
        PODCheck()
        CrystalCheck()
    End Sub
    Private Sub PODChests_MouseDown(sender As Object, e As EventArgs) Handles PODChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(PODChests,5,-1,1)
                If PODChests.Text = 0 Then PODLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                NumChange(PODChests,14,1,1)
                PODLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub PODPrizes_MouseDown(sender As Object, e As EventArgs) Handles PODPrizes.MouseDown
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(PODPrizes,5,-1,1)
                If PODPrizes.Text = 0 Then PODLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 9 Then
                    NumChange(PODPrizes,5,1,1)
                Else
                    NumChange(PODPrizes,11,1,1)
                End If
                PODLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub PODKeys_MouseDown(sender As Object, e As EventArgs) Handles PODKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(PODKeys,6,1)
        If MouseButtons = MouseButtons.Right Then NumChange(PODKeys,6,-1)
        PODCheck()
    End Sub
    Public Sub PODCheck()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If Pearl And (Aganhim Or (Hammer And Glove > 0) Or (Glove = 2 And Flippers)) And Bow > 1 And Hammer Then
                PODBoss.Enabled = True
                If Lamp Then
                    LCLR(PODLabel)
                    PODBorder.BackColor = Color.White
                    LChests(PODChests,14,Color.White)
                Else
                    LSQB(PODLabel)
                    LChests(PODChests,14,Color.Orange)
                    PODBorder.BackColor = Color.White
                End If
            ElseIf Pearl And (Aganhim Or (Hammer And Glove > 0) Or (Glove = 2 And Flippers)) And Bow > 1 Then
                PODBoss.Enabled = False
                LChests(PODChests,13,Color.Yellow)
                LPCLR(PODLabel)
                PODBorder.BackColor = Color.Black
            ElseIf Pearl And (Aganhim Or (Hammer And Glove > 0) Or (Glove = 2 And Flippers)) Then
                PODBoss.Enabled = False
                LChests(PODChests,11,Color.Yellow)
                LPCLR(PODLabel)
                PODBorder.BackColor = Color.Black
            Else
                PODChests.Text = 0
                PODChests.ForeColor = Color.White
                LOFF(PODLabel)
                PODBoss.Enabled = False
                PODBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 7 Then
            If Pearl And (Aganhim Or (Hammer And Glove > 0) Or (Glove = 2 And Flippers)) And Bow > 1 And Hammer And PODBigKey.Checked = True And PODKeys.Text > 0 Then
                PODBoss.Enabled = True
                If Lamp And PODKeys.Text = 6 Then
                    LCLR(PODLabel)
                    PODBorder.BackColor = Color.White
                ElseIf PODKeys.Text = 6 Then
                    LSQB(PODLabel)
                    PODBorder.BackColor = Color.White
                Else
                    LPCLR(PODLabel)
                    PODBorder.BackColor = Color.Black
                End If
            ElseIf Pearl And (Aganhim Or (Hammer And Glove > 0) Or (Glove = 2 And Flippers)) Then
                LPCLR(PODLabel)
                PODBoss.Enabled = False
                PODBorder.BackColor = Color.Black
            Else
                LOFF(PODLabel)
                PODBoss.Enabled = False
                PODBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If Bow > 1 And Hammer Then
                PODBoss.Enabled = True
                If Lamp Then
                    LCLR(PODLabel)
                    PODBorder.BackColor = Color.White
                    LChests(PODChests,14,Color.White)
                Else
                    LSQB(PODLabel)
                    LChests(PODChests,14,Color.Orange)
                    PODBorder.BackColor = Color.White
                End If
            ElseIf Lamp And Bow > 1 And (Hammer Or Flippers Or (Mirror And InvertedLWAcc()) Or (Flute And Pearl And InvertedLWAcc())) Then
                PODBoss.Enabled = False
                LChests(PODChests,13,Color.Yellow)
                LPCLR(PODLabel)
                PODBorder.BackColor = Color.Black
            ElseIf Lamp And (Hammer Or Flippers Or (Mirror And InvertedLWAcc()) Or (Flute And Pearl And InvertedLWAcc())) Then
                PODBoss.Enabled = False
                LChests(PODChests,11,Color.Yellow)
                LPCLR(PODLabel)
                PODBorder.BackColor = Color.Black
            ElseIf Hammer Or Flippers Or (Mirror And InvertedLWAcc()) Or (Flute And Pearl And InvertedLWAcc()) Then
                PODBoss.Enabled = False
                LChests(PODChests,11,Color.Yellow)
                LPCLR(PODLabel)
                PODBorder.BackColor = Color.Black
            Else
                LChests(PODChests,0,Color.White)
                LOFF(PODLabel)
                PODBoss.Enabled = False
                PODBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If Hammer And Bow > 1 And PODBigKey.Checked = True And PODKeys.Text > 0 Then
                PODBoss.Enabled = True
                If Lamp And PODKeys.Text = 6 Then
                    LCLR(PODLabel)
                    PODBorder.BackColor = Color.White
                ElseIf PODKeys.Text = 6 Then
                    LSQB(PODLabel)
                    PODBorder.BackColor = Color.White
                Else
                    LPCLR(PODLabel)
                    PODBorder.BackColor = Color.Black
                End If
            ElseIf Hammer Or Flippers Or (Mirror And InvertedLWAcc()) Or (Flute And Pearl And InvertedLWAcc()) Then
                LPCLR(PODLabel)
                PODBoss.Enabled = False
                PODBorder.BackColor = Color.Black
            Else
                LOFF(PODLabel)
                PODBoss.Enabled = False
                PODBorder.BackColor = Color.Black
            End IF
        End If
    End Sub
    Private Sub SPClick(sender As Object, e As EventArgs) Handles SPMap.CheckedChanged, SPBigKey.CheckedChanged, SPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "SPMap"
                If SPMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If SPReward = -1 Then SPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "SPBigKey"
                If SPBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
            Case "SPBoss"
                If SPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    SPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    SPButton.BackColor = Color.Black
                End If
        End Select
        SPCheck()
        CrystalCheck()
    End Sub
    Private Sub SPChests_MouseDown(sender As Object, e As EventArgs) Handles SPChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(SPChests,10,-1,1)
                If SPChests.Text = 0 Then SPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                NumChange(SPChests,10,1,1)
				SPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SPPrizes_MouseDown(sender As Object, e As EventArgs) Handles SPPrizes.MouseDown
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(SPPrizes,10,-1,1)
                If SPPrizes.Text = 0 Then SPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 9 Then
                    NumChange(SPPrizes,6,1,1)
                Else
                    NumChange(SPPrizes,7,1,1)
                End If
                SPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SPKeys_MouseDown(sender As Object, e As EventArgs) Handles SPKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(SPKeys,1,1)
        If MouseButtons = MouseButtons.Right Then NumChange(SPKeys,1,-1)
		SPCheck()
    End Sub
    Public Sub SPCheck()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If Pearl And Flippers And Mirror And Hammer And Hookshot And (Glove > 0 Or Aganhim) Then
                LCLR(SPLabel)
                LChests(SPChests,10,Color.White)
                SPBoss.Enabled = True
                SPBorder.BackColor = Color.White
            ElseIf Pearl And Flippers And Mirror And Hammer And (Glove > 0 Or Aganhim) Then
                LPCLR(SPLabel)
                LChests(SPChests,6,Color.Yellow)
                SPBoss.Enabled = False
                SPBorder.BackColor = Color.Black
            ElseIf Pearl And Flippers And Mirror And (Glove = 2 Or (Aganhim And Hookshot)) Then
                LPCLR(SPLabel)
                LChests(SPChests,2,Color.Yellow)
                SPBoss.Enabled = False
                SPBorder.BackColor = Color.Black
            Else
                LOFF(SPLabel)
                LChests(SPChests,0,Color.White)
                SPBoss.Enabled = False
                SPBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 7 Then
            If Pearl And Flippers And Mirror And Hammer And Hookshot And (Glove > 0 Or Aganhim) And SPKeys.Text = 1 Then
                LCLR(SPLabel)
                SPBoss.Enabled = True
                SPBorder.BackColor = Color.White
            ElseIf Pearl And Flippers And Mirror And (Glove = 2 Or (Hammer And (Glove > 0 Or Aganhim))) Then
                LPCLR(SPLabel)
                SPBoss.Enabled = False
                SPBorder.BackColor = Color.Black
            Else
                LOFF(SPLabel)
                SPBoss.Enabled = False
                SPBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If Pearl And Flippers And Mirror And Hammer And Hookshot And InvertedLWAcc() Then
                LCLR(SPLabel)
                LChests(SPChests,10,Color.White)
                SPBoss.Enabled = True
                SPBorder.BackColor = Color.White
            ElseIf Pearl And Flippers And Mirror And Hammer And InvertedLWAcc() Then
                LPCLR(SPLabel)
                LChests(SPChests,6,Color.Yellow)
                SPBoss.Enabled = False
                SPBorder.BackColor = Color.Black
            ElseIf Pearl And Flippers And Mirror And InvertedLWAcc() Then
                LPCLR(SPLabel)
                LChests(SPChests,2,Color.Yellow)
                SPBoss.Enabled = False
                SPBorder.BackColor = Color.Black
            Else
                LOFF(SPLabel)
                LChests(SPChests,0,Color.White)
                SPBoss.Enabled = False
                SPBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If Pearl And Flippers And Mirror And Hammer And Hookshot And InvertedLWAcc() And SPKeys.Text = 1 Then
                LCLR(SPLabel)
                SPBoss.Enabled = True
                SPBorder.BackColor = Color.White
            ElseIf Pearl And Flippers And Mirror And InvertedLWAcc() Then
                LPCLR(SPLabel)
                SPBoss.Enabled = False
                SPBorder.BackColor = Color.Black
            Else
                LOFF(SPLabel)
                SPBoss.Enabled = False
                SPBorder.BackColor = Color.Black
            End If
        End If

    End Sub

    Private Sub SWClick(sender As Object, e As EventArgs) Handles SWMap.CheckedChanged, SWBigKey.CheckedChanged, SWBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "SWMap"
                If SWMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If SWReward = -1 Then SWButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "SWBigKey"
                If SWBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
            Case "SWBoss"
                If SWBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    SWButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    SWButton.BackColor = Color.Black
                End If
        End Select
        SWCheck()
        CrystalCheck()
    End Sub
    Private Sub SWChests_MouseDown(sender As Object, e As EventArgs) Handles SWChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(SWChests,8,-1,1)
                If SWChests.Text = 0 Then SWLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                NumChange(SWChests,8,1,1)
                SWLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SWPrizes_MouseDown(sender As Object, e As EventArgs) Handles SWPrizes.MouseDown
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(SWPrizes,2,-1,1)
                If SWPrizes.Text = 0 Then SWLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 9 Then
                    NumChange(SWPrizes,2,1,1)
                Else
                    NumChange(SWPrizes,5,1,1)
                End If
                SWLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub SWKeys_MouseDown(sender As Object, e As EventArgs) Handles SWKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(SWKeys,3,1)
        If MouseButtons = MouseButtons.Right Then NumChange(SWKeys,3,-1)
		SWCheck()
    End Sub


    Public Sub SWCheck()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If Pearl And (Glove = 2 Or (Glove > 0 And Hammer) Or (Aganhim And Hookshot And (Glove Or Hammer Or Flippers))) And FireRod And SLcheck(1,0) Then
                LCLR(SWLabel)
                LChests(SWChests,8,Color.White)
                SWBoss.Enabled = True
                SWBorder.BackColor = Color.White
            ElseIf Pearl And (Glove = 2 Or (Glove > 0 And Hammer) Or (Aganhim And Hookshot And (Glove Or Hammer Or Flippers))) And FireRod Then
                LPCLR(SWLabel)
                LChests(SWChests,7,Color.Yellow)
                SWBoss.Enabled = False
                SWBorder.BackColor = Color.Black
            ElseIf Pearl And (Glove = 2 Or (Glove > 0 And Hammer) Or (Aganhim And Hookshot And (Glove Or Hammer Or Flippers))) Then
                LPCLR(SWLabel)
                LChests(SWChests,6,Color.Yellow)
                SWBoss.Enabled = False
                SWBorder.BackColor = Color.Black
            Else
                LOFF(SWLabel)
                LChests(SWChests,0,Color.White)
                SWBoss.Enabled = False
                SWBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 7 Then
            If Pearl And (Glove = 2 Or (Glove > 0 And Hammer) Or (Aganhim And Hookshot And (Glove Or Hammer Or Flippers))) And FireRod And SLcheck(1,0) Then
                If SWKeys.Text >= 2 Then LCLR(SWLabel) Else LSQB(SWLabel)
                SWBoss.Enabled = True
                SWBorder.BackColor = Color.White
            ElseIf Pearl And (Glove = 2 Or (Glove > 0 And Hammer) Or (Aganhim And Hookshot And (Glove Or Hammer Or Flippers))) Then
                LPCLR(SWLabel)
                SWBoss.Enabled = False
                SWBorder.BackColor = Color.Black
            Else
                SWLabel.BackColor = Color.Red
                SWLabel.ForeColor = Color.Black
                SWBoss.Enabled = False
                SWBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If FireRod And SLcheck(1,0) Then
                LCLR(SWLabel)
                LChests(SWChests,8,Color.White)
                SWBoss.Enabled = True
                SWBorder.BackColor = Color.White
            ElseIf FireRod Then
                LPCLR(SWLabel)
                LChests(SWChests,7,Color.Yellow)
                SWBoss.Enabled = False
                SWBorder.BackColor = Color.Black
            Else
                LPCLR(SWLabel)
                LChests(SWChests,6,Color.Yellow)
                SWBoss.Enabled = False
                SWBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If FireRod And SLcheck(1,0) Then
                If SWKeys.Text >= 2 Then LCLR(SWLabel) Else LSQB(SWLabel)
                SWBoss.Enabled = True
                SWBorder.BackColor = Color.White
            Else
                LPCLR(SWLabel)
                SWBoss.Enabled = False
                SWBorder.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub TTClick(sender As Object, e As EventArgs) Handles TTMap.CheckedChanged, TTBigKey.CheckedChanged, TTBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "TTMap"
                If TTMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If TTReward = -1 Then TTButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "TTBigKey"
                If TTBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    TTBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    TTBigKey.BackColor = Color.Red
                End If
            Case "TTBoss"
                If TTBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    TTButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    TTButton.BackColor = Color.Black
                End If
        End Select
        TTCheck()
        CrystalCheck()
    End Sub

    Private Sub TTPrizes_MouseDown(sender As Object, e As EventArgs) Handles TTPrizes.MouseDown
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(TTPrizes,4,-1,1)
                If TTPrizes.Text = 0 Then TTLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 9 Then
                    NumChange(TTPrizes,4,1,1)
                Else
                    NumChange(TTPrizes,5,1,1)
                End If
                TTLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TTChests_MouseDown(sender As Object, e As EventArgs) Handles TTChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
        If MouseButtons = MouseButtons.Left Then
                NumChange(TTChests,8,-1,1)
                If TTChests.Text = 0 Then TTLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                NumChange(TTChests,8,1,1)
                TTLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub TTKeys_MouseDown(sender As Object, e As EventArgs) Handles TTKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(TTKeys,1,1)
        If MouseButtons = MouseButtons.Right Then NumChange(TTKeys,1,-1)
		TTCheck()
    End Sub

    Public Sub TTCheck()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If Pearl And (Glove = 2 Or (Glove > 0 And Hammer) Or (Aganhim And Hookshot And (Glove Or Hammer Or Flippers))) Then
                LCLR(TTLabel)
                If Hammer Then LChests(TTChests,8,Color.White) Else LChests(TTChests,7,Color.Yellow)
                TTBoss.Enabled = True
                TTBorder.BackColor = Color.White
            Else
                LOFF(TTLabel)
                LChests(TTChests,0,Color.White)
                TTBoss.Enabled = False
                TTBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 7 Then
            If Pearl And TTBigKey.Checked = True And (Glove = 2 Or (Glove > 0 And Hammer) Or (Aganhim And Hookshot And (Glove Or Hammer Or Flippers))) Then
                If TTKeys.Text = 1 Then LCLR(TTLabel) Else LSQB(TTLabel)
                TTBoss.Enabled = True
                TTBorder.BackColor = Color.White
            ElseIf Pearl And (Glove = 2 Or (Glove > 0 And Hammer) Or (Aganhim And Hookshot And (Glove Or Hammer Or Flippers))) Then
                LPCLR(TTLabel)
                TTBoss.Enabled = False
                TTBorder.BackColor = Color.Black
            Else
                LOFF(TTLabel)
                TTBoss.Enabled = False
                TTBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If Hammer Then
                LCLR(TTLabel)
                LChests(TTChests,8,Color.White)
                TTBoss.Enabled = True
                TTBorder.BackColor = Color.White
            ElseIf Sword > 0 Or Somaria Or Byrna Then
                LPCLR(TTLabel)
                LChests(TTChests,7,Color.Yellow)
                TTBoss.Enabled = True
                TTBorder.BackColor = Color.Black
            Else
                LPCLR(TTLabel)
                LChests(TTChests,6,Color.Yellow)
                TTBoss.Enabled = False
                TTBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If TTBigKey.Checked = True And Hammer Then
                If TTKeys.Text = 1 Then LCLR(TTLabel) Else LSQB(TTLabel)
                TTBoss.Enabled = True
                TTBorder.BackColor = Color.White
            ElseIf TTBigKey.Checked = True And (Sword > 0 Or Somaria Or Byrna) Then
                LSQB(TTLabel)
                TTBoss.Enabled = True
                TTBorder.BackColor = Color.Black
            Else
                LPCLR(TTLabel)
                TTBoss.Enabled = False
                TTBorder.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub IPClick(sender As Object, e As EventArgs) Handles IPMap.CheckedChanged, IPBigKey.CheckedChanged, IPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "IPMap"
                If IPMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If IPReward = -1 Then IPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "IPBigKey"
                If IPBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
            Case "IPBoss"
                If IPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    IPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    IPButton.BackColor = Color.Black
                End If
        End Select
        IPCheck()
        CrystalCheck()
    End Sub
    Private Sub IPPrizes_MouseDown(sender As Object, e As EventArgs) Handles IPPrizes.MouseDown
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(IPPrizes,3,-1,1)
                If IPPrizes.Text = 0 Then IPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 9 Then
                    NumChange(IPPrizes,3,1,1)
                Else
                    NumChange(IPPrizes,5,1,1)
                End If
                IPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub IPChests_MouseDown(sender As Object, e As EventArgs) Handles IPChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
        If MouseButtons = MouseButtons.Left Then
                NumChange(IPChests,8,-1,1)
                If IPChests.Text = 0 Then IPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                NumChange(IPChests,8,1,1)
                IPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub IPKeys_MouseDown(sender As Object, e As EventArgs) Handles IPKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(IPKeys,2,1)
        If MouseButtons = MouseButtons.Right Then NumChange(IPKeys,2,-1)
        IPCheck()
    End Sub

    Public Sub IPCheck()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If Pearl And Glove = 2 And (FireRod Or (Bombos And SLcheck())) And Hammer And (Hookshot Or Somaria) Then
                IPBoss.Enabled = True
                If Flippers Then
                    LCLR(IPLabel)
                    LChests(IPChests,8,Color.White)
                Else
                    LSQB(IPLabel)
                    LChests(IPChests,8,Color.Orange)
                End If
                IPBorder.BackColor = Color.White
            ElseIf Pearl And Glove = 2 And (FireRod Or (Bombos And SLcheck())) And Hammer Then
                LPCLR(IPLabel)
                If Flippers Then LChests(IPChests,8,Color.Yellow) Else LChests(IPChests,8,Color.Orange)
                IPBoss.Enabled = True
                IPBorder.BackColor = Color.Black
            ElseIf Pearl And Glove = 2 And (FireRod Or (Bombos And SLcheck())) Then
                LPCLR(IPLabel)
                If Flippers Then LChests(IPChests,7,Color.Yellow) Else LChests(IPChests,7,Color.Orange)
                IPBoss.Enabled = False
                IPBorder.BackColor = Color.Black
            Else
                LOFF(IPLabel)
                LChests(IPChests,0,Color.White)
                IPBoss.Enabled = False
                IPBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 7 Then
            If Pearl And Glove = 2 And (FireRod Or (Bombos And SLcheck())) And Hammer Then
                If Flippers And ((IPKeys.Text = 2 And IPBigKey.Checked = True) Or (IPKeys.Text >= 1 And IPBigKey.Checked = True And Somaria)) Then LCLR(IPLabel) Else LSQB(IPLabel)
                IPLabel.ForeColor = Color.White
                IPBoss.Enabled = True
                IPBorder.BackColor = Color.White
            ElseIf Pearl And Glove = 2 And Flippers And (FireRod Or (Bombos And SLcheck())) Then
                LPCLR(IPLabel)
                IPBoss.Enabled = False
                IPBorder.BackColor = Color.Black
            Else
                LOFF(IPLabel)
                IPBoss.Enabled = False
                IPBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If (FireRod Or (Bombos And SLcheck())) And Hammer And Glove > 0 Then
                IPBoss.Enabled = True
                If Flippers Then
                    LCLR(IPLabel)
                    LChests(IPChests,8,Color.White)
                Else
                    LSQB(IPLabel)
                    LChests(IPChests,8,Color.Orange)
                End If
                IPBorder.BackColor = Color.White
            ElseIf (FireRod Or (Bombos And SLcheck())) Then
                If Hammer And Glove > 0 Then
                    LSQB(IPLabel)
                    LChests(IPChests,8,Color.Orange)
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.White
                ElseIf FLippers Then
                    LPCLR(IPLabel)
                    LChests(IPChests,5,Color.Yellow)
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                End If
            Else
                LOFF(IPLabel)
                LChests(IPChests,0,Color.White)
                IPBoss.Enabled = False
                IPBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If (FireRod Or (Bombos And SLcheck())) And Hammer And Glove > 0 Then
                If Flippers And ((IPKeys.Text = 2 And IPBigKey.Checked = True) Or (IPKeys.Text >= 1 And IPBigKey.Checked = True And Somaria)) Then LCLR(IPLabel) Else LSQB(IPLabel)
                IPBoss.Enabled = True
                IPBorder.BackColor = Color.White
            ElseIf Flippers And (FireRod Or (Bombos And SLcheck())) Then
                LPCLR(IPLabel)
                IPBoss.Enabled = False
                IPBorder.BackColor = Color.Black
            Else
                LOFF(IPLabel)
                IPBoss.Enabled = False
                IPBorder.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub MMClick(sender As Object, e As EventArgs) Handles MMMap.CheckedChanged, MMBigKey.CheckedChanged, MMBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "MMMap"
                If MMMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If MMReward = -1 Then MMButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "MMBigKey"
                If MMBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    MMBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    MMBigKey.BackColor = Color.Red
                End If
            Case "MMBoss"
                If MMBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    MMButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    MMButton.BackColor = Color.Black
                End If
        End Select
        MMCheck()
        CrystalCheck()
    End Sub
    Private Sub MMPrizes_MouseDown(sender As Object, e As EventArgs) Handles MMPrizes.MouseDown
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(MMPrizes,2,-1,1)
                If MMPrizes.Text = 0 Then MMLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 9 Then
                    NumChange(MMPrizes,2,1,1)
                Else
                    NumChange(MMPrizes,5,1,1)
                End If
                MMLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub MMChests_MouseDown(sender As Object, e As EventArgs) Handles MMChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
        If MouseButtons = MouseButtons.Left Then
                NumChange(MMChests,8,-1,1)
                If MMChests.Text = 0 Then MMLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                NumChange(MMChests,8,1,1)
                MMLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub MMKeys_MouseDown(sender As Object, e As EventArgs) Handles MMKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(MMKeys,3,1)
        If MouseButtons = MouseButtons.Right Then NumChange(MMKeys,3,-1)
        MMCheck()
    End Sub
    Public Sub MMCheck()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If Pearl And Glove = 2 And Flute And (Hookshot Or Boots) And MMMedCheck() And Somaria Then
                MMBoss.Enabled = True
                MMBorder.BackColor = Color.White
                If Lamp Then
                    LCLR(MMLabel)
                    LChests(MMChests,8,Color.White)
                Else
                    LSQB(MMLabel)
                    LChests(MMChests,8,Color.Orange)
                End If
            ElseIf Pearl And Glove = 2 And Flute And SLcheck() And (Hookshot  Or Boots) And MedallionCount > 0 And MireMedallion = 0 Then
                LPCLR(MMLabel)
                MMBorder.BackColor = Color.Black
                If Somaria Then
                    MMBoss.Enabled = True
                    LChests(MMChests,8,Color.Yellow)
                Else
                    MMBoss.Enabled = False
                    LChests(MMChests,7,Color.Yellow)
                End If
            ElseIf Pearl And Glove = 2 And Flute And SLcheck() And (Hookshot Or Boots) And MMMedCheck() Then
                LPCLR(MMLabel)
                LChests(MMChests,7,Color.White)
                MMBoss.Enabled = False
                MMBorder.BackColor = Color.Black
            Else
                LOFF(MMLabel)
                LChests(MMChests,0,Color.White)
                MMBoss.Enabled = False
                MMBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 7 Then
            If Pearl And Glove = 2 And Flute And SLcheck() And (Hookshot Or Boots) And MMMedCheck() And Somaria And MMBigKey.Checked = True Then
                If Lamp Then LCLR(MMLabel) Else LSQB(MMLabel)
                MMBoss.Enabled = True
                MMBorder.BackColor = Color.White
            ElseIf Pearl And Glove = 2 And Flute And SLcheck() And (Hookshot Or Boots) And MedallionCount > 0 And MireMedallion = 0 Then
                MMLabel.BackColor = Color.Yellow
                MMLabel.ForeColor = Color.Black
                If Somaria Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                MMBorder.BackColor = Color.Black
            ElseIf Pearl And Glove = 2 And Flute And SLcheck() And (Hookshot Or Boots) And MMMedCheck() Then
                LPCLR(MMLabel)
                MMBoss.Enabled = False
                MMBorder.BackColor = Color.Black
            Else
                LOFF(MMLabel)
                MMBoss.Enabled = False
                MMBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If ((Flute And Pearl And InvertedLWAcc()) Or (InvertedLWAcc() And Mirror)) And SLcheck() And (Hookshot Or Boots) And MMMedCheck() And Somaria Then
                MMBoss.Enabled = True
                MMBorder.BackColor = Color.White
                If Lamp Then
                    LCLR(MMLabel)
                    LChests(MMChests,8,Color.White)
                Else
                    LSQB(MMLabel)
                    LChests(MMChests,8,Color.Orange)
                End If
            ElseIf ((Flute And Pearl And InvertedLWAcc()) Or (InvertedLWAcc() And Mirror)) And SLcheck() And (Hookshot  Or Boots) And MedallionCount > 0 And MireMedallion = 0 Then
                LPCLR(MMLabel)
                MMBorder.BackColor = Color.Black
                If Somaria Then
                    MMBoss.Enabled = True
                    LChests(MMChests,8,Color.Yellow)
                Else
                    MMBoss.Enabled = False
                    LChests(MMChests,7,Color.Yellow)
                End If
            ElseIf ((Flute And Pearl And InvertedLWAcc()) Or (InvertedLWAcc() And Mirror)) And SLcheck() And (Hookshot Or Boots) And MMMedCheck() Then
                LPCLR(MMLabel)
                LChests(MMChests,7,Color.White)
                MMBoss.Enabled = False
                MMBorder.BackColor = Color.Black
            Else
                LOFF(MMLabel)
                LChests(MMChests,0,Color.White)
                MMBoss.Enabled = False
                MMBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If (Mirror Or (Flute And Pearl)) And InvertedLWAcc() And SLcheck() And (Hookshot Or Boots) And MMMedCheck() And Somaria And MMBigKey.Checked = True Then
                If Lamp Then MMLabel.BackColor = Color.Green Else MMLabel.BackColor = Color.Orange
                MMLabel.ForeColor = Color.White
                MMBoss.Enabled = True
                MMBorder.BackColor = Color.White
            ElseIf (Mirror Or (Flute And Pearl)) And InvertedLWAcc() And (Hookshot Or Boots) And MedallionCount > 0 And MireMedallion = 0 Then
                MMLabel.BackColor = Color.Yellow
                MMLabel.ForeColor = Color.Black
                If Somaria Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                MMBorder.BackColor = Color.Black
            ElseIf (Mirror Or (Flute And Pearl)) And InvertedLWAcc() And (Hookshot Or Boots) And MMMedCheck() Then
                LPCLR(MMLabel)
                MMBoss.Enabled = False
                MMBorder.BackColor = Color.Black
            Else
                LOFF(MMLabel)
                MMBoss.Enabled = False
                MMBorder.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub MireBEQ_Click(sender As Object, e As EventArgs) Handles MireBEQ.MouseDown
        MireMedallion = (MireMedallion + 1) Mod 4
        Select Case MireMedallion
            Case 0
                MireBEQ.Image = My.Resources.whatmedallion
            Case 1
                MireBEQ.Image = My.Resources.bombos
            Case 2
                MireBEQ.Image = My.Resources.ether
            Case 3
                MireBEQ.Image = My.Resources.quake
        End Select
        MMCheck()
    End Sub
    Private Sub TRClick(sender As Object, e As EventArgs) Handles TRMap.CheckedChanged, TRBigKey.CheckedChanged, TRBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "TRMap"
                If TRMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If TRReward = -1 Then TRButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "TRBigKey"
                If TRBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    TRBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    TRBigKey.BackColor = Color.Red
                End If
            Case "TRBoss"
                If TRBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    TRButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    TRButton.BackColor = Color.Black
                End If
        End Select
        TRCheck()
        CrystalCheck()
    End Sub
    Private Sub TRPrizes_MouseDown(sender As Object, e As EventArgs) Handles TRPrizes.MouseDown
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If MouseButtons = MouseButtons.Left Then
                NumChange(TRPrizes,5,-1,1)
                If TRPrizes.Text = 0 Then TRLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 9 Then
                    NumChange(TRPrizes,5,1,1)
                Else
                    NumChange(TRPrizes,9,1,1)
                End If
                TRLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TRChests_MouseDown(sender As Object, e As EventArgs) Handles TRChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
        If MouseButtons = MouseButtons.Left Then
                NumChange(TRChests,12,-1,1)
                If TRChests.Text = 0 Then TRLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right Then
                NumChange(TRChests,12,1,1)
                TRLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TRKeys_MouseDown(sender As Object, e As EventArgs) Handles TRKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(TRKeys,4,1)
        If MouseButtons = MouseButtons.Right Then NumChange(TRKeys,4,-1)
        TRCheck()
    End Sub

    Public Sub TRCheck()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Then
            If Pearl And Glove = 2 And Hammer And Somaria And FireRod And IceRod And (Hookshot Or Mirror) And TRMedCheck() Then
                TRAccess = True
                If Lamp And ((SLcheck(3) Or Hammer) Or (SLcheck(2) And canExtendMagic()) Or (SLcheck() And canExtendMagic(4))) Then
                    LCLR(TRLabel)
                    LChests(TRChests,12,Color.White)
                Else
                    LSQB(TRLabel)
                    LChests(TRChests,12,Color.Orange)
                End If
                TRBorder.BackColor = Color.White
                TRBoss.Enabled = True
                If Mirror Then
                    CCLR(LW45)
                Else
                    COFF(LW45)
                End If
            ElseIf Pearl And Glove = 2 And Hammer And Somaria And (Hookshot Or Mirror) And MedallionCount > 0 And TurtleMedallion = 0 Then
                TRAccess = True
                LPCLR(TRLabel)
                TRBorder.BackColor = Color.Black
                If FireRod And IceRod Then
                    LChests(TRChests,12,Color.Yellow)
                    TRBoss.Enabled = True
                ElseIf FireRod Then
                    LChests(TRChests,11,Color.Yellow)
                    TRBoss.Enabled = False
                Else
                    LChests(TRChests,9,Color.Yellow)
                    TRBoss.Enabled = False
                End If
                If Mirror Then
                    CPCLR(LW45)
                Else
                    COFF(LW45)
                End If
            ElseIf Pearl And Glove = 2 And Hammer And Somaria And (Hookshot Or Mirror) And TRMedCheck() And FireRod Then
                TRAccess = True
                If Lamp Then LChests(TRChests,11,Color.White) Else LChests(TRChests,11,Color.Yellow)
                LPCLR(TRLabel)
                TRBoss.Enabled = False
                TRBorder.BackColor = Color.Black
                If Mirror Then
                    CCLR(LW45)
                Else
                    COFF(LW45)
                End If
            ElseIf Pearl And Glove = 2 And Hammer And Somaria And Sword > 0 And (Hookshot Or Mirror) Then
                TRAccess = True
                LChests(TRChests,9,Color.Yellow)
                LPCLR(TRLabel)
                TRBoss.Enabled = False
                TRBorder.BackColor = Color.Black
                If Mirror Then
                    CPCLR(LW45)
                Else
                    COFF(LW45)
                End If
            Else
                TRAccess = False
                LOFF(TRLabel)
                LChests(TRChests,0,Color.White)
                TRBoss.Enabled = False
                TRBorder.BackColor = Color.Black
                COFF(LW45)
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 7 Then
            If Pearl And Glove = 2 And Hammer And Somaria And FireRod And IceRod And (Hookshot Or Mirror) And TRMedCheck() And TRBigKey.Checked = True And TRKeys.Text >= 3 Then
                TRAccess = True
                If Lamp And TRKeys.Text = 4 And ((SLcheck(3) Or Hammer) Or (SLcheck(2) And canExtendMagic()) Or (SLcheck() And canExtendMagic(4))) Then
                    LCLR(TRLabel)
                ElseIf TRKeys.Text = 4 Then
                    LSQB(TRLabel)
                ElseIf TRKeys.Text = 3 Then
                    LPCLR(TRLabel)
                End If
                TRBoss.Enabled = True
                TRBorder.BackColor = Color.White
                If Mirror Then
                    CCLR(LW45)
                Else
                    COFF(LW45)
                End If
            ElseIf Pearl And Glove = 2 And Hammer And Somaria And SLcheck() And (Hookshot Or Mirror) And TurtleMedallion = 0 And MedallionCount > 0 Then
                TRAccess = True
                LPCLR(TRLabel)
                TRBorder.BackColor = Color.Black
                If FireRod And IceRod Then TRBoss.Enabled = True Else TRBoss.Enabled = False
                If TRKeys.Text >= 2 And Mirror Then
                    LW45.Enabled = True
                    LW45.BackColor = Color.Yellow
                Else
                    COFF(LW45)
                End If
            ElseIf Pearl And Glove = 2 And Hammer And Somaria And (Hookshot Or Mirror) And TRMedCheck() Then
                TRAccess = True
                LPCLR(TRLabel)
                TRBoss.Enabled = False
                TRBorder.BackColor = Color.Black
                If TRKeys.Text >= 2 And Mirror Then
                    CCLR(LW45)
                Else
                    COFF(LW45)
                End If
            Else
                TRAccess = False
                LOFF(TRLabel)
                TRBoss.Enabled = False
                TRBorder.BackColor = Color.Black
                COFF(LW45)
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
            If FireRod And IceRod And Somaria And ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) And (TRMedCheck() Or (Mirror And (Glove = 2 Or (Pearl And Hookshot)))) Then
                TRAccess = True
                If Lamp And ((SLcheck(3) Or Hammer) Or (SLcheck(2) And canExtendMagic()) Or (SLcheck() And canExtendMagic(4))) Then
                    LCLR(TRLabel)
                    LChests(TRChests,12,Color.White)
                Else
                    LSQB(TRLabel)
                    LChests(TRChests,12,Color.Orange)
                End If
                TRBorder.BackColor = Color.White
                TRBoss.Enabled = True
            ElseIf ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) And ((Somaria And TRMedCheck()) Or (Mirror And (Glove = 2 Or (Pearl And Hookshot)))) And MedallionCount > 0 And TurtleMedallion = 0 Then
                TRAccess = True
                LPCLR(TRLabel)
                TRBorder.BackColor = Color.Black
                If FireRod And IceRod And Somaria Then
                    LChests(TRChests,12,Color.Yellow)
                    TRBoss.Enabled = True
                ElseIf FireRod And Somaria Then
                    LChests(TRChests,11,Color.Yellow)
                    TRBoss.Enabled = False
                Else
                    LChests(TRChests,8,Color.Yellow)
                    TRBoss.Enabled = False
                End If
            ElseIf ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) And ((Somaria And TRMedCheck()) Or (Mirror And (Glove = 2 Or (Pearl And Hookshot)))) And FireRod Then
                TRAccess = True
                If Somaria Then TRChests.Text = 11 Else TRChests.Text = 10
                If Lamp Then TRChests.ForeColor = Color.White Else TRChests.ForeColor = Color.Yellow
                LPCLR(TRLabel)
                TRBoss.Enabled = False
                TRBorder.BackColor = Color.Black
            ElseIf ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) And ((Somaria And TRMedCheck()) Or (Mirror And (Glove = 2 Or (Pearl And Hookshot)))) Then
                TRAccess = True
                LChests(TRChests,9,Color.Yellow)
                LPCLR(TRLabel)
                TRBoss.Enabled = False
                TRBorder.BackColor = Color.Black
            Else
                TRAccess = False
                LOFF(TRLabel)
                LChests(TRChests,0,Color.White)
                TRBoss.Enabled = False
                TRBorder.BackColor = Color.Black
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 10 Then
            If ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) And ((Somaria And TRMedCheck()) Or (Mirror And (Glove = 2 Or (Pearl And Hookshot)))) And TRBigKey.Checked = True And TRKeys.Text >= 3 Then
                TRAccess = True
                If Lamp And TRKeys.Text = 4 And ((SLcheck(3) Or Hammer) Or (SLcheck(2) And canExtendMagic()) Or (SLcheck() And canExtendMagic(4))) Then
                    LCLR(TRLabel)
                    TRBorder.BackColor = Color.White
                ElseIf TRKeys.Text = 4 Then
                    LSQB(TRLabel)
                    TRBorder.BackColor = Color.White
                ElseIf TRKeys.Text = 3 Then
                    LPCLR(TRLabel)
                    TRBorder.BackColor = Color.Black
                End If
                TRBoss.Enabled = True
            ElseIf ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) And (Somaria Or (Mirror And (Glove = 2 Or (Pearl And Hookshot)))) And TurtleMedallion = 0 And MedallionCount > 0 Then
                TRAccess = True
                LPCLR(TRLabel)
                TRBorder.BackColor = Color.Black
                If FireRod And IceRod And Somaria Then TRBoss.Enabled = True Else TRBoss.Enabled = False
            ElseIf ((Glove > 0 And Lamp) Or (Flute And Pearl And InvertedLWAcc())) And ((Somaria And TRMedCheck()) Or (Mirror And (Glove = 2 Or (Pearl And Hookshot)))) Then
                TRAccess = True
                LPCLR(TRLabel)
                TRBoss.Enabled = False
                TRBorder.BackColor = Color.Black
            Else
                TRAccess = False
                LOFF(TRLabel)
                TRBoss.Enabled = False
                TRBorder.BackColor = Color.Black
            End If
        End If
        If LW45.Checked = True Then LW45.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub TurtleBEQ_Click(sender As Object, e As EventArgs) Handles TurtleBEQ.MouseDown
        TurtleMedallion = (TurtleMedallion + 1) Mod 4
        Select Case TurtleMedallion
            Case 0
                TurtleBEQ.Image = My.Resources.whatmedallion
            Case 1
                TurtleBEQ.Image = My.Resources.bombos
            Case 2
                TurtleBEQ.Image = My.Resources.ether
            Case 3
                TurtleBEQ.Image = My.Resources.quake
        End Select
        LWCheck()
        DWCheck()
        TRCheck()
    End Sub

    Private Sub GTClick(sender As Object, e As EventArgs) Handles GTBigKey.CheckedChanged
        If GTBigKey.Checked = True Then
            DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
            GTBigKey.BackColor = Color.WhiteSmoke
        Else
            DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
            GTBigKey.BackColor = Color.Red
        End If
        GTCheck()
    End Sub

    Private Sub GTChests_MouseDown(sender As Object, e As EventArgs) Handles GTChests.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(GTChests,27,-1,1)
        If MouseButtons = MouseButtons.Right Then NumChange(GTChests,27,1,1)
    End Sub

    Private Sub GTKeys_MouseDown(sender As Object, e As EventArgs) Handles GTKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then NumChange(GTKeys,4,1)
        If MouseButtons = MouseButtons.Right Then NumChange(GTKeys,4,-1)
    End Sub

    Public Sub GTCheck()
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
        If CrystalCount = 7 And GTBigKey.Checked = True Then
                LCLR(GTLabel)
                GTBorder.BackColor = Color.White
            ElseIf CrystalCount = 7 Then
                LPCLR(GTLabel)
                GTBorder.BackColor = Color.Black
            Else
                LOFF(GTLabel)
                GTBorder.BackColor = Color.Black
            End If
        End If
    End Sub

    
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Dim a As Integer = MsgBox("Are you sure you want to reset everything?", vbOKCancel)
        If a = DialogResult.OK Then
            ' Resetting all items
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
            {
                New Single() {0.299, 0.299, 0.299, 0, 0},
                New Single() {0.587, 0.587, 0.587, 0, 0},
                New Single() {0.114, 0.114, 0.114, 0, 0},
                New Single() {0, 0, 0, 1, 0},
                New Single() {0, 0, 0, 0, 1}
            })

            Dim nobow As New Bitmap(My.Resources.nobow)
            Dim noboomerang As New Bitmap(My.Resources.redboom)
            Dim nohook As New Bitmap(My.Resources.hookshot)
            Dim nobombs As New Bitmap(My.Resources.bombs)
            Dim nopowder As New Bitmap(My.Resources.powder)
            Dim nofirerod As New Bitmap(My.Resources.firerod)
            Dim noicerod As New Bitmap(My.Resources.icerod)
            Dim nobombos As New Bitmap(My.Resources.bombos)
            Dim noether As New Bitmap(My.Resources.ether)
            Dim noquake As New Bitmap(My.Resources.quake)
            Dim nolamp As New Bitmap(My.Resources.lamp)
            Dim nohammer As New Bitmap(My.Resources.hammer)
            Dim noflute As New Bitmap(My.Resources.flute)
            Dim nobugnet As New Bitmap(My.Resources.bugnet)
            Dim nobook As New Bitmap(My.Resources.book)
            Dim nobottle As New Bitmap(My.Resources.bottle)
            Dim nosomaria As New Bitmap(My.Resources.somaria)
            Dim nobyrna As New Bitmap(My.Resources.byrna)
            Dim nocape As New Bitmap(My.Resources.cape)
            Dim nomirror As New Bitmap(My.Resources.mirror)
            Dim noboots As New Bitmap(My.Resources.boots)
            Dim noglove As New Bitmap(My.Resources.glove)
            Dim noflippers As New Bitmap(My.Resources.flippers)
            Dim nopearl As New Bitmap(My.Resources.pearl)
            Dim nomushroom As New Bitmap(My.Resources.mushroom)
            Dim noshovel As New Bitmap(My.Resources.shovel)
            Dim nosword As New Bitmap(My.Resources.nosword)
            Dim noshield As New Bitmap(My.Resources.shield1)
            Dim noaganhim As New Bitmap(My.Resources.aganhim)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobow)
                g.DrawImage(nobow, New Rectangle(0, 0, nobow.Width, nobow.Height),
                        0, 0, nobow.Width, nobow.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(noboomerang)
                g.DrawImage(noboomerang, New Rectangle(0, 0, noboomerang.Width, noboomerang.Height),
                        0, 0, noboomerang.Width, noboomerang.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nohook)
                g.DrawImage(nohook, New Rectangle(0, 0, nohook.Width, nohook.Height),
                        0, 0, nohook.Width, nohook.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nobombs)
                g.DrawImage(nobombs, New Rectangle(0, 0, nobombs.Width, nobombs.Height),
                        0, 0, nobombs.Width, nobombs.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nopowder)
                g.DrawImage(nopowder, New Rectangle(0, 0, nopowder.Width, nopowder.Height),
                        0, 0, nopowder.Width, nopowder.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nofirerod)
                g.DrawImage(nofirerod, New Rectangle(0, 0, nofirerod.Width, nofirerod.Height),
                        0, 0, nofirerod.Width, nofirerod.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(noicerod)
                g.DrawImage(noicerod, New Rectangle(0, 0, noicerod.Width, noicerod.Height),
                        0, 0, noicerod.Width, noicerod.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nobombos)
                g.DrawImage(nobombos, New Rectangle(0, 0, nobombos.Width, nobombos.Height),
                        0, 0, nobombos.Width, nobombos.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(noether)
                g.DrawImage(noether, New Rectangle(0, 0, noether.Width, noether.Height),
                        0, 0, noether.Width, noether.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(noquake)
                g.DrawImage(noquake, New Rectangle(0, 0, noquake.Width, noquake.Height),
                        0, 0, noquake.Width, noquake.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nolamp)
                g.DrawImage(nolamp, New Rectangle(0, 0, nolamp.Width, nolamp.Height),
                        0, 0, nolamp.Width, nolamp.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nohammer)
                g.DrawImage(nohammer, New Rectangle(0, 0, nohammer.Width, nohammer.Height),
                        0, 0, nohammer.Width, nohammer.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(noflute)
                g.DrawImage(noflute, New Rectangle(0, 0, noflute.Width, noflute.Height),
                        0, 0, noflute.Width, noflute.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nobugnet)
                g.DrawImage(nobugnet, New Rectangle(0, 0, nobugnet.Width, nobugnet.Height),
                        0, 0, nobugnet.Width, nobugnet.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nobook)
                g.DrawImage(nobook, New Rectangle(0, 0, nobook.Width, nobook.Height),
                        0, 0, nobook.Width, nobook.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nobottle)
                g.DrawImage(nobottle, New Rectangle(0, 0, nobottle.Width, nobottle.Height),
                        0, 0, nobottle.Width, nobottle.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nosomaria)
                g.DrawImage(nosomaria, New Rectangle(0, 0, nosomaria.Width, nosomaria.Height),
                        0, 0, nosomaria.Width, nosomaria.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nobyrna)
                g.DrawImage(nobyrna, New Rectangle(0, 0, nobyrna.Width, nobyrna.Height),
                        0, 0, nobyrna.Width, nobyrna.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nocape)
                g.DrawImage(nocape, New Rectangle(0, 0, nocape.Width, nocape.Height),
                        0, 0, nocape.Width, nocape.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nomirror)
                g.DrawImage(nomirror, New Rectangle(0, 0, nomirror.Width, nomirror.Height),
                        0, 0, nomirror.Width, nomirror.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(noboots)
                g.DrawImage(noboots, New Rectangle(0, 0, noboots.Width, noboots.Height),
                        0, 0, noboots.Width, noboots.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(noglove)
                g.DrawImage(noglove, New Rectangle(0, 0, noglove.Width, noglove.Height),
                        0, 0, noglove.Width, noglove.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(noflippers)
                g.DrawImage(noflippers, New Rectangle(0, 0, noflippers.Width, noflippers.Height),
                        0, 0, noflippers.Width, noflippers.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nopearl)
                g.DrawImage(nopearl, New Rectangle(0, 0, nopearl.Width, nopearl.Height),
                        0, 0, nopearl.Width, nopearl.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nomushroom)
                g.DrawImage(nomushroom, New Rectangle(0, 0, nomushroom.Width, nomushroom.Height),
                        0, 0, nomushroom.Width, nomushroom.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(noshovel)
                g.DrawImage(noshovel, New Rectangle(0, 0, noshovel.Width, noshovel.Height),
                        0, 0, noshovel.Width, noshovel.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(nosword)
                g.DrawImage(nosword, New Rectangle(0, 0, nosword.Width, nosword.Height),
                        0, 0, nosword.Width, nosword.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(noshield)
                g.DrawImage(noshield, New Rectangle(0, 0, noshield.Width, noshield.Height),
                        0, 0, noshield.Width, noshield.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            Using g As Graphics = Graphics.FromImage(noaganhim)
                g.DrawImage(noaganhim, New Rectangle(0, 0, noaganhim.Width, noaganhim.Height),
                        0, 0, noaganhim.Width, noaganhim.Height,
                        GraphicsUnit.Pixel, imgattr)
            End Using
            BowButton.Image = nobow
            BowButton.BackColor = Color.Black
            BoomButton.Image = noboomerang
            BoomButton.BackColor = Color.Black
            HookButton.Image = nohook
            HookButton.BackColor = Color.Black
            BombButton.Image = nobombs
            BombButton.BackColor = Color.Black
            PowderButton.Image = nopowder
            PowderButton.BackColor = Color.Black
            FireButton.Image = nofirerod
            FireButton.BackColor = Color.Black
            IceButton.Image = noicerod
            IceButton.BackColor = Color.Black
            BombosButton.Image = nobombos
            BombosButton.BackColor = Color.Black
            EtherButton.Image = noether
            EtherButton.BackColor = Color.Black
            QuakeButton.Image = noquake
            QuakeButton.BackColor = Color.Black
            LampButton.Image = nolamp
            LampButton.BackColor = Color.Black
            HammerButton.Image = nohammer
            HammerButton.BackColor = Color.Black
            FluteButton.Image = noflute
            FluteButton.BackColor = Color.Black
            NetButton.Image = nobugnet
            NetButton.BackColor = Color.Black
            BookButton.Image = nobook
            BookButton.BackColor = Color.Black
            BottleButton.Image = nobottle
            BottleButton.BackColor = Color.Black
            SomariaButton.Image = nosomaria
            SomariaButton.BackColor = Color.Black
            ByrnaButton.Image = nobyrna
            ByrnaButton.BackColor = Color.Black
            CapeButton.Image = nocape
            CapeButton.BackColor = Color.Black
            MirrorButton.Image = nomirror
            MirrorButton.BackColor = Color.Black
            BootButton.Image = noboots
            BootButton.BackColor = Color.Black
            GloveButton.Image = noglove
            GloveButton.BackColor = Color.Black
            FlipperButton.Image = noflippers
            FlipperButton.BackColor = Color.Black
            PearlButton.Image = nopearl
            PearlButton.BackColor = Color.Black
            MushButton.Image = nomushroom
            MushButton.BackColor = Color.Black
            ShovelButton.Image = noshovel
            ShovelButton.BackColor = Color.Black
            SwordButton.Image = nosword
            SwordButton.BackColor = Color.Black
            ArmorButton.Image = My.Resources.greenmail
            ShieldButton.Image = noshield
            ShieldButton.BackColor = Color.Black
            MagicButton.Image = My.Resources.magicbottle
            Magic = 0
            Bow = 0
            Boomerang = 0
            Hookshot = False
            Bombs = False
            Powder = False
            FireRod = False
            IceRod = False
            Bombos = False
            Ether = False
            Quake = False
            Lamp = False
            Hammer = False
            Flute = False
            Net = False
            Book = False
            Bottle = False
            BottleNumber.Text = 0
            Somaria = False
            Byrna = False
            Cape = False
            Mirror = False
            Boots = False
            Glove = 0
            Flippers = False
            Pearl = False
            Mushroom = False
            Shovel = False
            Sword = 0
            Armor = 0
            Shield = 0
            MedallionCount = 0
            ' Resetting all dungeons
            LOFF(HCLabel)
            HCKeys.Text = 0 : NumChange(HCKeys,1)
            HCPrizes.Text = 6 : NumChange(HCPrizes,6,,1)
            If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
                HCChests.Text = 5 : NumChange(HCChests,5,,1)
            Else 
                HCChests.Text = 8 : NumChange(HCChests,8,,1)
            End If
            LOFF(EPLabel)
            EPKeys.Text = "-"
            EPPrizes.Text = 3 : NumChange(EPPrizes,3,,1)
            If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
                EPChests.Text = 5 : NumChange(EPChests,5,,1)
            Else
                EPChests.Text = 6 : NumChange(EPChests,5,,1)
            End If
            LOFF(DPLabel)
            DPKeys.Text = 0 : NumChange(DPKeys,1)
            DPPrizes.Text = 2 : NumChange(DPPrizes,2,,1)            
            If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
                DPChests.Text = 0 : NumChange(DPChests,4)
            Else
                DPChests.Text = 6 : NumChange(DPChests,6,,1)
            End If
            LOFF(TOHLabel)
            TOHKeys.Text = 0 : NumChange(TOHKeys,1)
            TOHPrizes.Text = 2 : NumChange(TOHPrizes,2,,1)
            If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
                TOHChests.Text = 0 : NumChange(TOHChests,6)
            Else
                TOHChests.Text = 6 : NumChange(TOHChests,6,,1)
            End If
            LOFF(AGLabel)
            AGKeys.Text = 0 : NumChange(AGKeys,2)
            AGChests.Text = 2 : NumChange(AGChests,2,,1)
            AGPrizes.Text = 2 : NumChange(AGPrizes,2,,1)
            AgaButton.Visible = False
            Aganhim = False
            LOFF(PODLabel)
            PODKeys.Text = 0 : NumChange(PODKeys,6)
            PODPrizes.Text = 5 : NumChange(PODPrizes,5,,1)
            If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
                PODChests.Text = 0 : NumChange(PODChests,14)
            Else
                PODChests.Text = 14 : NumChange(PODChests,14,,1)
            End If
            LOFF(SPLabel)
            SPKeys.Text = 0  : NumChange(SPKeys,1)
            SPPrizes.Text = 6  : NumChange(SPPrizes,6,,1)
            If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
                SPChests.Text = 0 : NumChange(SPChests,6)
            Else
                SPChests.Text = 10 : NumChange(SPChests,10,,1)
            End If
            LOFF(SWLabel)
            SWKeys.Text = 0 : NumChange(SWKeys,3)
            SWPrizes.Text = 2 : NumChange(SWPrizes,2,,1)
            If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
                SWChests.Text = 0 : NumChange(SWChests,2)
            Else
                SWChests.Text = 8 : NumChange(SWChests,8,,1)
            End If
            LOFF(TTLabel)
            TTKeys.Text = 0 : NumChange(TTKeys,1)
            TTPrizes.Text = 4 : NumChange(TTPrizes,4,,1)
            If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
                TTChests.Text = 0 : NumChange(TTChests,8)
            Else
                TTChests.Text = 8 : NumChange(TTChests,8,,1)
            End If
            
            LOFF(IPLabel)
            IPKeys.Text = 0 : NumChange(IPKeys,3)
            IPPrizes.Text = 3 : NumChange(IPPrizes,3,,1)
            If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
                IPChests.Text = 0 : NumChange(IPChests,3)
            Else
                IPChests.Text = 8 : NumChange(IPChests,8,,1)
            End If
            LOFF(MMLabel)
            MMKeys.Text = 0 : NumChange(MMKeys,3)
            MMPrizes.Text = 2 : NumChange(MMPrizes,2,,1)
            If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
                MMChests.Text = 0 : NumChange(MMChests,8)
            Else
                MMChests.Text = 8 : NumChange(MMChests,8,,1)
            End If
            MireMedallion = 0
            MireBEQ.Image = My.Resources.whatmedallion
            LOFF(TRLabel)
            TRKeys.Text = 0 : NumChange(TRKeys,4)
            TRPrizes.Text = 5 : NumChange(TRPrizes,5,,1)
            If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Or ComboBox1.SelectedIndex = 8 Or ComboBox1.SelectedIndex = 9 Or ComboBox1.SelectedIndex = 11 Then
                TRChests.Text = 0 : NumChange(TRChests,12)
            Else
                TRChests.Text = 12 : NumChange(TRChests,12,,1)
            End If
            TurtleMedallion = 0
            TurtleBEQ.Image = My.Resources.whatmedallion
            LOFF(GTLabel)
            GTKeys.Text = 0 : NumChange(GTKeys,4)
            GTChests.Text = 27 : NumChange(GTChests,27,,1)
                

            If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 7 Or ComboBox1.SelectedIndex = 10 Then
                EPReward = -1
                DPReward = -1
                TOHReward = -1
                PODReward = -1
                SPReward = -1
                SWReward = -1
                TTReward = -1
                IPReward = -1
                MMReward = -1
                TRReward = -1
                For Each Pic in {EPButton, DPButton, TOHButton, PODButton, SPButton, SWButton, TTButton, IPButton, MMButton, TRButton}
                    SwitchCrystal(Pic,-1)
                Next
            Else
                EPReward = 0
                DPReward = 0
                TOHReward = 0
                PODReward = 0
                SPReward = 0
                SWReward = 0
                TTReward = 0
                IPReward = 0
                MMReward = 0
                TRReward = 0
                For Each Pic in {EPButton, DPButton, TOHButton, PODButton, SPButton, SWButton, TTButton, IPButton, MMButton, TRButton}
                    SwitchCrystal(Pic,0)
                Next
            End If

            For Each Label as System.Windows.Forms.Label in {EPLabel2, DPLabel2, TOHLabel2, PODLabel2, SPLabel2, SWLabel2, TTLabel2, IPLabel2, MMLabel2, TRLabel2}
                Label.BackColor = Color.Black
            Next
            For Each Check as System.Windows.Forms.CheckBox in {EPMap, EPBigKey, EPBoss, DPMap, DPBigKey, DPBoss, HeraMap, HeraBigKey, HeraBoss, PODMap, PODBigKey, PODBoss, SPMap, SPBigKey, SPBoss, SWMap, SWBigKey, SWBoss, TTMap, TTBigKey, TTBoss, IPMap, IPBigKey, IPBoss, MMMap, MMBigKey, MMBoss, TRMap, TRBigKey, TRBoss, GTBigKey}
                    Check.Checked = False
            Next
            ' Resetting all Sphere 1 locations
            For Each Check as System.Windows.Forms.CheckBox in {LW1, LW2, LW7, LW8, LW9, LW10, LW11, LW13, LW17, LW32, LW36, DW2, DW3, DW4, DW5, DW10}
                Check.Checked = False
            Next
            ' Resetting all scoutable items
            For Each But as System.Windows.Forms.Button in {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11, Button12}
                But.Image = My.Resources.chestmaybesmall
            Next
            For Each Scout as Integer in {AgaTree, Library, Maze, SpecRock, EtherTab, Floating, DPLedge, BombosTab, ZoraLedge, LakeIsle, Pedestal, Bumper}
                Scout = 0
            Next
            ' Resetting all dungeons and overworld locations
            AllCheck()
        End If
    End Sub

    Private Sub DW15Boots_CheckedChanged(sender As Object, e As EventArgs) Handles DW15Boots.CheckedChanged
        If DW15Boots.Checked = True Then DW15Boots.BackColor = Color.FromArgb(64, 64, 64) Else DW15Boots.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub MagicButton_Click(sender As Object, e As EventArgs) Handles MagicButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Magic = (Magic + 1) Mod 3 Else Magic = (Magic + 2) Mod 3
        Select Case Magic
            Case 0
                MagicButton.Image = My.Resources.magicbottle
            Case 1
                MagicButton.Image = My.Resources.halfmagic
            Case 2
                MagicButton.Image = My.Resources.quartermagic
        End Select
        TRCheck()
        DWCheck()
    End Sub
    
    Private Sub SwitchCrystal(Pic as System.Windows.Forms.PictureBox, Reward As Integer)
        Select Case Reward
            Case -1
                Pic.Image = Nothing
            Case 0
                Pic.Image = My.Resources.crystal
            Case 1
                Pic.Image = My.Resources.fairycrystal
            Case 2
                Pic.Image = My.Resources.otherpendant
            Case 3
                Pic.Image = My.Resources.greenpendant
        End Select
    End Sub 

    Private Sub CrystalClick(sender As Object, e As EventArgs) Handles EPButton.MouseDown, DPButton.MouseDown, TOHButton.MouseDown, PODButton.MouseDown, SPButton.MouseDown, SWButton.MouseDown, TTButton.MouseDown, IPButton.MouseDown, MMButton.MouseDown, TRButton.MouseDown
        Select Case DirectCast(sender, PictureBox).Name
            Case "EPButton"
                If MouseButtons = MouseButtons.Left Then EPReward = (EPReward + 1) Mod 4 Else EPReward = -1
                SwitchCrystal(EPButton, EPReward)
            Case "DPButton"
                If MouseButtons = MouseButtons.Left Then DPReward = (DPReward + 1) Mod 4 Else DPReward = -1
                SwitchCrystal(DPButton, DPReward)
            Case "TOHButton"
                If MouseButtons = MouseButtons.Left Then TOHReward = (TOHReward + 1) Mod 4 Else TOHReward = -1
                SwitchCrystal(TOHButton, TOHReward)
            Case "PODButton"
                If MouseButtons = MouseButtons.Left Then PODReward = (PODReward + 1) Mod 4 Else PODReward = -1
                SwitchCrystal(PODButton, PODReward)
            Case "SPButton"
                If MouseButtons = MouseButtons.Left Then SPReward = (SPReward + 1) Mod 4 Else SPReward = -1
                SwitchCrystal(SPButton, SPReward)
            Case "SWButton"
                If MouseButtons = MouseButtons.Left Then SWReward = (SWReward + 1) Mod 4 Else SWReward = -1
                SwitchCrystal(SWButton, SWReward)
            Case "TTButton"
                If MouseButtons = MouseButtons.Left Then TTReward = (TTReward + 1) Mod 4 Else TTReward = -1
                SwitchCrystal(TTButton, TTReward)
            Case "IPButton"
                If MouseButtons = MouseButtons.Left Then IPReward = (IPReward + 1) Mod 4 Else IPReward = -1
                SwitchCrystal(IPButton, IPReward)
            Case "MMButton"
                If MouseButtons = MouseButtons.Left Then MMReward = (MMReward + 1) Mod 4 Else MMReward = -1
                SwitchCrystal(MMButton, MMReward)
            Case "TRButton"
                If MouseButtons = MouseButtons.Left Then TRReward = (TRReward + 1) Mod 4 Else TRReward = -1
                SwitchCrystal(TRButton, TRReward)
        End Select
        LWCheck()
        DWCheck()
        CrystalCheck()
    End Sub

    Private Sub Count(ByVal Reward as Integer)
        Select Case Reward
            Case 0
                CrystalCount += 1
            Case 1
                CrystalCount += 1
                FairyCrystal += 1
            Case 2
                PendantCount += 1
            Case 3
                PendantCount += 1
                GreenPendant = True
        End Select
    End Sub

    Public Sub CrystalCheck()
        CrystalCount = 0
        FairyCrystal = 0
        PendantCount = 0
        GreenPendant = False

        If EPBoss.Checked = True Then Count(EPReward) 
        If DPBoss.Checked = True Then Count(DPReward) 
        If HeraBoss.Checked = True Then Count(TOHReward)
        If PODBoss.Checked = True Then Count(PODReward)
        If SPBoss.Checked = True Then Count(SPReward)
        If SWBoss.Checked = True Then Count(SWReward)
        If TTBoss.Checked = True Then Count(TTReward)
        If IPBoss.Checked = True Then Count(IPReward)
        If MMBoss.Checked = True Then Count(MMReward)
        If TRBoss.Checked = True Then Count(TRReward)
        LWCheck()
        DWCheck()
        GTCheck()
    End Sub

    Private Sub BowButton_Click(sender As Object, e As EventArgs) Handles BowButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Bow = (Bow + 1) Mod 4 Else Bow = (Bow + 3) Mod 4
        Select Case Bow
            Case 0
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

                Dim nobow As New Bitmap(My.Resources.nobow)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(nobow)
                    g.DrawImage(nobow, New Rectangle(0, 0, nobow.Width, nobow.Height),
                    0, 0, nobow.Width, nobow.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                BowButton.Image = nobow
                BowButton.BackColor = Color.Black
            Case 1
                BowButton.Image = My.Resources.Agsonly
                BowButton.BackColor = Color.WhiteSmoke
            Case 2
                BowButton.Image = My.Resources.bow
                BowButton.BackColor = Color.WhiteSmoke
            Case 3
                BowButton.Image = My.Resources.silvers
                BowButton.BackColor = Color.WhiteSmoke
        End Select
        AllCheck()
    End Sub

    Private Sub BoomButton_Click(sender As Object, e As EventArgs) Handles BoomButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Boomerang = (Boomerang + 1) Mod 4 Else Boomerang = (Boomerang + 3) Mod 4
        Select Case Boomerang
            Case 0
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

                Dim noboomerang As New Bitmap(My.Resources.blueboom)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(noboomerang)
                    g.DrawImage(noboomerang, New Rectangle(0, 0, noboomerang.Width, noboomerang.Height),
                    0, 0, noboomerang.Width, noboomerang.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                BoomButton.Image = noboomerang
                BoomButton.BackColor = Color.Black
            Case 1
                BoomButton.Image = My.Resources.blueboom
                BoomButton.BackColor = Color.WhiteSmoke
            Case 2
                BoomButton.Image = My.Resources.redboom
                BoomButton.BackColor = Color.WhiteSmoke
            Case 3
                BoomButton.Image = My.Resources.bothboom
                BoomButton.BackColor = Color.WhiteSmoke
        End Select
    End Sub

    Private Sub HookButton_Click(sender As Object, e As EventArgs) Handles HookButton.MouseDown
        If Hookshot = False Then Hookshot = True Else Hookshot = False
        If Hookshot = True Then
            HookButton.Image = My.Resources.hookshot
            HookButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nohook As New Bitmap(My.Resources.hookshot)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nohook)
                g.DrawImage(nohook, New Rectangle(0, 0, nohook.Width, nohook.Height),
                    0, 0, nohook.Width, nohook.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            HookButton.Image = nohook
            HookButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub BombButton_Click(sender As Object, e As EventArgs) Handles BombButton.MouseDown
        If Bombs = False Then Bombs = True Else Bombs = False
        If Bombs = True Then
            BombButton.Image = My.Resources.bombs
            BombButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nobombs As New Bitmap(My.Resources.bombs)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobombs)
                g.DrawImage(nobombs, New Rectangle(0, 0, nobombs.Width, nobombs.Height),
                    0, 0, nobombs.Width, nobombs.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            BombButton.Image = nobombs
            BombButton.BackColor = Color.Black
        End If
    AllCheck()
    End Sub

    Private Sub PowderButton_Click(sender As Object, e As EventArgs) Handles PowderButton.MouseDown
        If Powder = False Then Powder = True Else Powder = False
        If Powder = True Then
            PowderButton.Image = My.Resources.powder
            PowderButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nopowder As New Bitmap(My.Resources.powder)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nopowder)
                g.DrawImage(nopowder, New Rectangle(0, 0, nopowder.Width, nopowder.Height),
                    0, 0, nopowder.Width, nopowder.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            PowderButton.Image = nopowder
            PowderButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub FireButton_Click(sender As Object, e As EventArgs) Handles FireButton.MouseDown
        If FireRod = False Then FireRod = True Else FireRod = False
        If FireRod = True Then
            FireButton.Image = My.Resources.firerod
            FireButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nofirerod As New Bitmap(My.Resources.firerod)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nofirerod)
                g.DrawImage(nofirerod, New Rectangle(0, 0, nofirerod.Width, nofirerod.Height),
                    0, 0, nofirerod.Width, nofirerod.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            FireButton.Image = nofirerod
            FireButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub IceButton_Click(sender As Object, e As EventArgs) Handles IceButton.MouseDown
        If IceRod = False Then IceRod = True Else IceRod = False
        If IceRod = True Then
            IceButton.Image = My.Resources.icerod
            IceButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noicerod As New Bitmap(My.Resources.icerod)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noicerod)
                g.DrawImage(noicerod, New Rectangle(0, 0, noicerod.Width, noicerod.Height),
                    0, 0, noicerod.Width, noicerod.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            IceButton.Image = noicerod
            IceButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub BombosButton_Click(sender As Object, e As EventArgs) Handles BombosButton.MouseDown
        If Bombos = False Then Bombos = True Else Bombos = False
        If Bombos = True Then
            BombosButton.Image = My.Resources.bombos
            BombosButton.BackColor = Color.WhiteSmoke
            MedallionCount = MedallionCount + 1
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nobombos As New Bitmap(My.Resources.bombos)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobombos)
                g.DrawImage(nobombos, New Rectangle(0, 0, nobombos.Width, nobombos.Height),
                    0, 0, nobombos.Width, nobombos.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            BombosButton.Image = nobombos
            BombosButton.BackColor = Color.Black
            MedallionCount = MedallionCount - 1
        End If
        AllCheck()
    End Sub

    Private Sub EtherButton_Click(sender As Object, e As EventArgs) Handles EtherButton.MouseDown
        If Ether = False Then Ether = True Else Ether = False
        If Ether = True Then
            EtherButton.Image = My.Resources.ether
            EtherButton.BackColor = Color.WhiteSmoke
            MedallionCount = MedallionCount + 1
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noether As New Bitmap(My.Resources.ether)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noether)
                g.DrawImage(noether, New Rectangle(0, 0, noether.Width, noether.Height),
                    0, 0, noether.Width, noether.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            EtherButton.Image = noether
            EtherButton.BackColor = Color.Black
            MedallionCount = MedallionCount - 1
        End If
        AllCheck()
    End Sub

    Private Sub QuakeButton_Click(sender As Object, e As EventArgs) Handles QuakeButton.MouseDown
        If Quake = False Then Quake = True Else Quake = False
        If Quake = True Then
            QuakeButton.Image = My.Resources.quake
            QuakeButton.BackColor = Color.WhiteSmoke
            MedallionCount = MedallionCount + 1
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noquake As New Bitmap(My.Resources.quake)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noquake)
                g.DrawImage(noquake, New Rectangle(0, 0, noquake.Width, noquake.Height),
                    0, 0, noquake.Width, noquake.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            QuakeButton.Image = noquake
            QuakeButton.BackColor = Color.Black
            MedallionCount = MedallionCount - 1
        End If
        AllCheck()
    End Sub

    Private Sub LampButton_Click(sender As Object, e As EventArgs) Handles LampButton.MouseDown
        If Lamp = False Then Lamp = True Else Lamp = False
        If Lamp = True Then
            LampButton.Image = My.Resources.lamp
            LampButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nolamp As New Bitmap(My.Resources.lamp)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nolamp)
                g.DrawImage(nolamp, New Rectangle(0, 0, nolamp.Width, nolamp.Height),
                    0, 0, nolamp.Width, nolamp.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            LampButton.Image = nolamp
            LampButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub HammerButton_Click(sender As Object, e As EventArgs) Handles HammerButton.MouseDown
        If Hammer = False Then Hammer = True Else Hammer = False
        If Hammer = True Then
            HammerButton.Image = My.Resources.hammer
            HammerButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nohammer As New Bitmap(My.Resources.hammer)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nohammer)
                g.DrawImage(nohammer, New Rectangle(0, 0, nohammer.Width, nohammer.Height),
                    0, 0, nohammer.Width, nohammer.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            HammerButton.Image = nohammer
            HammerButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub FluteButton_Click(sender As Object, e As EventArgs) Handles FluteButton.MouseDown
        If Flute = False Then Flute = True Else Flute = False
        If Flute = True Then
            FluteButton.Image = My.Resources.flute
            FluteButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noflute As New Bitmap(My.Resources.flute)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noflute)
                g.DrawImage(noflute, New Rectangle(0, 0, noflute.Width, noflute.Height),
                    0, 0, noflute.Width, noflute.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            FluteButton.Image = noflute
            FluteButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub NetButton_Click(sender As Object, e As EventArgs) Handles NetButton.MouseDown
        If Net = False Then Net = True Else Net = False
        If Net = True Then
            NetButton.Image = My.Resources.bugnet
            NetButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nobugnet As New Bitmap(My.Resources.bugnet)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobugnet)
                g.DrawImage(nobugnet, New Rectangle(0, 0, nobugnet.Width, nobugnet.Height),
                    0, 0, nobugnet.Width, nobugnet.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            NetButton.Image = nobugnet
            NetButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.MouseDown
        If Book = False Then Book = True Else Book = False
        If Book = True Then
            BookButton.Image = My.Resources.book
            BookButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nobook As New Bitmap(My.Resources.book)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobook)
                g.DrawImage(nobook, New Rectangle(0, 0, nobook.Width, nobook.Height),
                    0, 0, nobook.Width, nobook.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            BookButton.Image = nobook
            BookButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub BottleButton_Click(sender As Object, e As EventArgs) Handles BottleButton.MouseDown, BottleNumber.MouseDown
        If MouseButtons = MouseButtons.Left Then
            BottleButton.Image = My.Resources.bottle
            BottleButton.BackColor = Color.WhiteSmoke
            Bottle = True
            BottleNumber.BackColor = Color.FromArgb(64, 64, 64)
            If BottleNumber.Text < 4 Then BottleNumber.Text += 1
        Else
            If BottleNumber.Text > 0 Then BottleNumber.Text -= 1
            If BottleNumber.Text = 0 Then
                Bottle = False
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

                Dim nobottle As New Bitmap(My.Resources.bottle)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(nobottle)
                    g.DrawImage(nobottle, New Rectangle(0, 0, nobottle.Width, nobottle.Height),
                    0, 0, nobottle.Width, nobottle.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                BottleButton.Image = nobottle
                BottleButton.BackColor = Color.Black
            End If
        End If
        AllCheck()
    End Sub

    Private Sub SomariaButton_Click(sender As Object, e As EventArgs) Handles SomariaButton.MouseDown
        If Somaria = False Then Somaria = True Else Somaria = False
        If Somaria = True Then
            SomariaButton.Image = My.Resources.somaria
            SomariaButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nosomaria As New Bitmap(My.Resources.somaria)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nosomaria)
                g.DrawImage(nosomaria, New Rectangle(0, 0, nosomaria.Width, nosomaria.Height),
                    0, 0, nosomaria.Width, nosomaria.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            SomariaButton.Image = nosomaria
            SomariaButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub ByrnaButton_Click(sender As Object, e As EventArgs) Handles ByrnaButton.MouseDown
        If Byrna = False Then Byrna = True Else Byrna = False
        If Byrna = True Then
            ByrnaButton.Image = My.Resources.byrna
            ByrnaButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nobyrna As New Bitmap(My.Resources.byrna)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobyrna)
                g.DrawImage(nobyrna, New Rectangle(0, 0, nobyrna.Width, nobyrna.Height),
                    0, 0, nobyrna.Width, nobyrna.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            ByrnaButton.Image = nobyrna
            ByrnaButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub CapeButton_Click(sender As Object, e As EventArgs) Handles CapeButton.MouseDown
        If Cape = False Then Cape = True Else Cape = False
        If Cape = True Then
            CapeButton.Image = My.Resources.cape
            CapeButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nocape As New Bitmap(My.Resources.cape)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nocape)
                g.DrawImage(nocape, New Rectangle(0, 0, nocape.Width, nocape.Height),
                    0, 0, nocape.Width, nocape.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            CapeButton.Image = nocape
            CapeButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub MirrorButton_Click(sender As Object, e As EventArgs) Handles MirrorButton.MouseDown
        If Mirror = False Then Mirror = True Else Mirror = False
        If Mirror = True Then
            MirrorButton.Image = My.Resources.mirror
            MirrorButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nomirror As New Bitmap(My.Resources.mirror)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nomirror)
                g.DrawImage(nomirror, New Rectangle(0, 0, nomirror.Width, nomirror.Height),
                    0, 0, nomirror.Width, nomirror.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            MirrorButton.Image = nomirror
            MirrorButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub BootButton_Click(sender As Object, e As EventArgs) Handles BootButton.MouseDown
        If Boots = False Then Boots = True Else Boots = False
        If Boots = True Then
            BootButton.Image = My.Resources.boots
            BootButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noboots As New Bitmap(My.Resources.boots)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noboots)
                g.DrawImage(noboots, New Rectangle(0, 0, noboots.Width, noboots.Height),
                    0, 0, noboots.Width, noboots.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            BootButton.Image = noboots
            BootButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub GloveButton_Click(sender As Object, e As EventArgs) Handles GloveButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Glove = (Glove + 1) Mod 3 Else Glove = (Glove + 2) Mod 3
        Select Case Glove
            Case 0
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

                Dim noglove As New Bitmap(My.Resources.glove)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(noglove)
                    g.DrawImage(noglove, New Rectangle(0, 0, noglove.Width, noglove.Height),
                    0, 0, noglove.Width, noglove.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                GloveButton.Image = noglove
                GloveButton.BackColor = Color.Black
            Case 1
                GloveButton.Image = My.Resources.glove
                GloveButton.BackColor = Color.WhiteSmoke
            Case 2
                GloveButton.Image = My.Resources.mitt
                GloveButton.BackColor = Color.WhiteSmoke
        End Select
        AllCheck()
    End Sub

    Private Sub FlipperButton_Click(sender As Object, e As EventArgs) Handles FlipperButton.MouseDown
        If Flippers = False Then Flippers = True Else Flippers = False
        If Flippers = True Then
            FlipperButton.Image = My.Resources.flippers
            FlipperButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noflippers As New Bitmap(My.Resources.flippers)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noflippers)
                g.DrawImage(noflippers, New Rectangle(0, 0, noflippers.Width, noflippers.Height),
                    0, 0, noflippers.Width, noflippers.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            FlipperButton.Image = noflippers
            FlipperButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub PearlButton_Click(sender As Object, e As EventArgs) Handles PearlButton.MouseDown
        If Pearl = False Then Pearl= True Else Pearl = False
        If Pearl Then
            PearlButton.Image = My.Resources.pearl
            PearlButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nopearl As New Bitmap(My.Resources.pearl)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nopearl)
                g.DrawImage(nopearl, New Rectangle(0, 0, nopearl.Width, nopearl.Height),
                    0, 0, nopearl.Width, nopearl.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            PearlButton.Image = nopearl
            PearlButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub MushButton_Click(sender As Object, e As EventArgs) Handles MushButton.MouseDown
        If Mushroom = False Then Mushroom = True Else Mushroom = False
        If Mushroom = True Then
            MushButton.Image = My.Resources.mushroom
            MushButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nomushroom As New Bitmap(My.Resources.mushroom)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nomushroom)
                g.DrawImage(nomushroom, New Rectangle(0, 0, nomushroom.Width, nomushroom.Height),
                    0, 0, nomushroom.Width, nomushroom.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            MushButton.Image = nomushroom
            MushButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub ShovelButton_Click(sender As Object, e As EventArgs) Handles ShovelButton.MouseDown
        If Shovel = False Then Shovel = True Else Shovel = False
        If Shovel = True Then
            ShovelButton.Image = My.Resources.shovel
            ShovelButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noshovel As New Bitmap(My.Resources.shovel)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noshovel)
                g.DrawImage(noshovel, New Rectangle(0, 0, noshovel.Width, noshovel.Height),
                    0, 0, noshovel.Width, noshovel.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            ShovelButton.Image = noshovel
            ShovelButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub AgaButton_Click(sender As Object, e As EventArgs) Handles AgaButton.MouseDown
        If Aganhim = False Then Aganhim = True Else Aganhim = False
        If Aganhim = True Then
            AgaButton.Image = My.Resources.aganhim
            AgaButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noaganhim As New Bitmap(My.Resources.aganhim)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noaganhim)
                g.DrawImage(noaganhim, New Rectangle(0, 0, noaganhim.Width, noaganhim.Height),
                    0, 0, noaganhim.Width, noaganhim.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            AgaButton.Image = noaganhim
            AgaButton.BackColor = Color.Black
        End If
        AllCheck()
    End Sub

    Private Sub SwordButton_Click(sender As Object, e As EventArgs) Handles SwordButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Sword = (Sword + 1) Mod 5 Else Sword = (Sword + 4) Mod 5
        Select Case Sword
            Case 0
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

                Dim nosword As New Bitmap(My.Resources.nosword)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(nosword)
                    g.DrawImage(nosword, New Rectangle(0, 0, nosword.Width, nosword.Height),
                    0, 0, nosword.Width, nosword.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                SwordButton.Image = nosword
                SwordButton.BackColor = Color.Black
            Case 1
                SwordButton.Image = My.Resources.sword1
                SwordButton.BackColor = Color.WhiteSmoke
            Case 2
                SwordButton.Image = My.Resources.sword2
                SwordButton.BackColor = Color.WhiteSmoke
            Case 3
                SwordButton.Image = My.Resources.sword3
                SwordButton.BackColor = Color.WhiteSmoke
            Case 4
                SwordButton.Image = My.Resources.sword4
                SwordButton.BackColor = Color.WhiteSmoke
        End Select
        AllCheck()
    End Sub

    Private Sub ArmorButton_Click(sender As Object, e As EventArgs) Handles ArmorButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Armor = (Armor + 1) Mod 3 Else Armor = (Armor + 2) Mod 3
        Select Case Armor
            Case 0
                ArmorButton.Image = My.Resources.greenmail
            Case 1
                ArmorButton.Image = My.Resources.bluemail
            Case 2
                ArmorButton.Image = My.Resources.redmail
        End Select

    End Sub

    Private Sub ShieldButton_Click(sender As Object, e As EventArgs) Handles ShieldButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Shield = (Shield + 1) Mod 4 Else Shield = (Shield + 3) Mod 4
        Select Case Shield
            Case 0
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

                Dim noshield As New Bitmap(My.Resources.shield1)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(noshield)
                    g.DrawImage(noshield, New Rectangle(0, 0, noshield.Width, noshield.Height),
                    0, 0, noshield.Width, noshield.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                ShieldButton.Image = noshield
                ShieldButton.BackColor = Color.Black
            Case 1
                ShieldButton.Image = My.Resources.shield1
                ShieldButton.BackColor = Color.WhiteSmoke
            Case 2
                ShieldButton.Image = My.Resources.shield2
                ShieldButton.BackColor = Color.WhiteSmoke
            Case 3
                ShieldButton.Image = My.Resources.shield3
                ShieldButton.BackColor = Color.WhiteSmoke
        End Select
        AllCheck()
    End Sub

    Private Sub HlpButton_Click(sender As Object, e As EventArgs) Handles HlpButton.MouseDown
        Form2.ShowDialog()
    End Sub

End Class
