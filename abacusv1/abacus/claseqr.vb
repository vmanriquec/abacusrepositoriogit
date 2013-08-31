Imports ThoughtWorks.QRCode
Imports ThoughtWorks.QRCode.Codec
Imports ThoughtWorks.QRCode.Codec.Data
Public Class claseqr
    Public Shared Function AdjustQRVersion(ByVal TextEncode As String, ByVal qrCodeErrCorrect As Codec.QRCodeEncoder.ERROR_CORRECTION) As Integer
        Dim textb() As Byte = System.Text.UTF8Encoding.UTF8.GetBytes(TextEncode)

        Dim ibits As Integer = ((textb.Length + 1) * 8) + 8

        Select Case qrCodeErrCorrect
            '////////////////////////////////// ERROR_CORRECTION.L  (7%) ////////////////////////////////////////
            Case QRCodeEncoder.ERROR_CORRECTION.L
                Select Case ibits
                    Case Is <= 152
                        Return 1
                    Case Is <= 272
                        Return 2
                    Case Is <= 440
                        Return 3
                    Case Is <= 640
                        Return 4
                    Case Is <= 864
                        Return 5
                    Case Is <= 1088
                        Return 6
                    Case Is <= 1248
                        Return 7
                    Case Is <= 1552
                        Return 8
                    Case Is <= 1856
                        Return 9
                    Case Is <= 2192
                        Return 10
                    Case Is <= 2592
                        Return 11
                    Case Is <= 2960
                        Return 12
                    Case Is <= 3424
                        Return 13
                    Case Is <= 3688
                        Return 14
                    Case Is <= 4184
                        Return 15
                    Case Is <= 4712
                        Return 16
                    Case Is <= 5176
                        Return 17
                    Case Is <= 5768
                        Return 18
                    Case Is <= 6360
                        Return 19
                    Case Is <= 6888
                        Return 20
                    Case Is <= 7456
                        Return 21
                    Case Is <= 8048
                        Return 22
                    Case Is <= 8752
                        Return 23
                    Case Is <= 9392
                        Return 24
                    Case Is <= 10208
                        Return 25
                    Case Is <= 10960
                        Return 26
                    Case Is <= 11744
                        Return 27
                    Case Is <= 12248
                        Return 28
                    Case Is <= 13048
                        Return 29
                    Case Is <= 13880
                        Return 30
                    Case Is <= 14744
                        Return 31
                    Case Is <= 15640
                        Return 32
                    Case Is <= 16568
                        Return 33
                    Case Is <= 17528
                        Return 34
                    Case Is <= 18448
                        Return 35
                    Case Is <= 19472
                        Return 36
                    Case Is <= 20528
                        Return 37
                    Case Is <= 21616
                        Return 38
                    Case Is <= 22496
                        Return 39
                    Case Is <= 23648
                        Return 40
                    Case Else
                        Return -1
                End Select
                '////////////////////////////////// ERROR_CORRECTION.M  (15%) ////////////////////////////////////////
            Case QRCodeEncoder.ERROR_CORRECTION.M
                Select Case ibits
                    Case Is <= 128
                        Return 1
                    Case Is <= 224
                        Return 2
                    Case Is <= 352
                        Return 3
                    Case Is <= 512
                        Return 4
                    Case Is <= 688
                        Return 5
                    Case Is <= 864
                        Return 6
                    Case Is <= 992
                        Return 7
                    Case Is <= 1232
                        Return 8
                    Case Is <= 1456
                        Return 9
                    Case Is <= 1728
                        Return 10
                    Case Is <= 2032
                        Return 11
                    Case Is <= 2320
                        Return 12
                    Case Is <= 2672
                        Return 13
                    Case Is <= 2920
                        Return 14
                    Case Is <= 3320
                        Return 15
                    Case Is <= 3624
                        Return 16
                    Case Is <= 4056
                        Return 17
                    Case Is <= 4504
                        Return 18
                    Case Is <= 5016
                        Return 19
                    Case Is <= 5352
                        Return 20
                    Case Is <= 5712
                        Return 21
                    Case Is <= 6256
                        Return 22
                    Case Is <= 6880
                        Return 23
                    Case Is <= 7312
                        Return 24
                    Case Is <= 8000
                        Return 25
                    Case Is <= 8496
                        Return 26
                    Case Is <= 9024
                        Return 27
                    Case Is <= 9544
                        Return 28
                    Case Is <= 10136
                        Return 29
                    Case Is <= 10984
                        Return 30
                    Case Is <= 11640
                        Return 31
                    Case Is <= 12328
                        Return 32
                    Case Is <= 13048
                        Return 33
                    Case Is <= 13800
                        Return 34
                    Case Is <= 14496
                        Return 35
                    Case Is <= 15312
                        Return 36
                    Case Is <= 15936
                        Return 37
                    Case Is <= 16816
                        Return 38
                    Case Is <= 17728
                        Return 39
                    Case Is <= 18672
                        Return 40
                    Case Else
                        Return -1
                End Select
                '////////////////////////////////// ERROR_CORRECTION.Q  (25%) ////////////////////////////////////////
            Case QRCodeEncoder.ERROR_CORRECTION.Q
                Select Case ibits
                    Case Is <= 104
                        Return 1
                    Case Is <= 176
                        Return 2
                    Case Is <= 272
                        Return 3
                    Case Is <= 384
                        Return 4
                    Case Is <= 496
                        Return 5
                    Case Is <= 608
                        Return 6
                    Case Is <= 704
                        Return 7
                    Case Is <= 880
                        Return 8
                    Case Is <= 1056
                        Return 9
                    Case Is <= 1232
                        Return 10
                    Case Is <= 1440
                        Return 11
                    Case Is <= 1648
                        Return 12
                    Case Is <= 1952
                        Return 13
                    Case Is <= 2088
                        Return 14
                    Case Is <= 2360
                        Return 15
                    Case Is <= 2600
                        Return 16
                    Case Is <= 2936
                        Return 17
                    Case Is <= 3176
                        Return 18
                    Case Is <= 3560
                        Return 19
                    Case Is <= 3880
                        Return 20
                    Case Is <= 4096
                        Return 21
                    Case Is <= 4544
                        Return 22
                    Case Is <= 4912
                        Return 23
                    Case Is <= 5312
                        Return 24
                    Case Is <= 5744
                        Return 25
                    Case Is <= 6032
                        Return 26
                    Case Is <= 6464
                        Return 27
                    Case Is <= 6968
                        Return 28
                    Case Is <= 7288
                        Return 29
                    Case Is <= 7880
                        Return 30
                    Case Is <= 8264
                        Return 31
                    Case Is <= 8920
                        Return 32
                    Case Is <= 9368
                        Return 33
                    Case Is <= 9848
                        Return 34
                    Case Is <= 10288
                        Return 35
                    Case Is <= 10832
                        Return 36
                    Case Is <= 11408
                        Return 37
                    Case Is <= 12016
                        Return 38
                    Case Is <= 12656
                        Return 39
                    Case Is <= 13328
                        Return 40
                    Case Else
                        Return -1
                End Select
                '////////////////////////////////// ERROR_CORRECTION.H  (30%) ////////////////////////////////////////
            Case QRCodeEncoder.ERROR_CORRECTION.H
                Select Case ibits
                    Case Is <= 72
                        Return 1
                    Case Is <= 128
                        Return 2
                    Case Is <= 208
                        Return 3
                    Case Is <= 288
                        Return 4
                    Case Is <= 368
                        Return 5
                    Case Is <= 480
                        Return 6
                    Case Is <= 528
                        Return 7
                    Case Is <= 688
                        Return 8
                    Case Is <= 800
                        Return 9
                    Case Is <= 976
                        Return 10
                    Case Is <= 1120
                        Return 11
                    Case Is <= 1264
                        Return 12
                    Case Is <= 1440
                        Return 13
                    Case Is <= 1576
                        Return 14
                    Case Is <= 1784
                        Return 15
                    Case Is <= 2024
                        Return 16
                    Case Is <= 2264
                        Return 17
                    Case Is <= 2504
                        Return 18
                    Case Is <= 2728
                        Return 19
                    Case Is <= 3080
                        Return 20
                    Case Is <= 3248
                        Return 21
                    Case Is <= 3536
                        Return 22
                    Case Is <= 3712
                        Return 23
                    Case Is <= 4112
                        Return 24
                    Case Is <= 4304
                        Return 25
                    Case Is <= 4768
                        Return 26
                    Case Is <= 5024
                        Return 27
                    Case Is <= 5288
                        Return 28
                    Case Is <= 5608
                        Return 29
                    Case Is <= 5960
                        Return 30
                    Case Is <= 6344
                        Return 31
                    Case Is <= 6760
                        Return 32
                    Case Is <= 7208
                        Return 33
                    Case Is <= 7688
                        Return 34
                    Case Is <= 7888
                        Return 35
                    Case Is <= 8432
                        Return 36
                    Case Is <= 8768
                        Return 37
                    Case Is <= 9136
                        Return 38
                    Case Is <= 9776
                        Return 39
                    Case Is <= 10208
                        Return 40
                    Case Else
                        Return -1
                End Select
        End Select
    End Function
End Class
