Imports System
Imports System.Security.Cryptography.X509Certificates
Imports System.Text

Module Program

    Sub Main(args As String())
        '���\�b�h1���Ăяo�����s
        PrefOutput1()
        '���\�b�h2���Ăяo�����s
        PrefOutput2()
        '���\�b�h3���Ăяo�����s
        PrefOutput3()
    End Sub

    '���\�b�h1�F�s���{�����J���}�łȂ�����������R���\�[���ɏo��
    Sub PrefOutput1()
        'StringBuilder�N���X�I�u�W�F�N�g�𐶐�
        Dim strSb1 As New System.Text.StringBuilder

        'PrefArr�z��̔z�񕪂����s���{����������擾
        For i = 0 To PrefArr.GetUpperBound(0)
            strSb1.Append(PrefArr(i) & ",")
        Next

        '�R���\�[���ɏo�́i���s�Ń��\�b�h2�Ƃ̊Ԃ�1�s�󂯂�j
        Console.WriteLine(strSb1.ToString() & vbCrLf)
    End Sub

    '���\�b�h2�FList(Of String)�̓s���{�����X�g���g���ăJ���}�Ōq������������쐬
    Sub PrefOutput2()
        'StringBuilder�N���X�I�u�W�F�N�g�𐶐�
        Dim strSb2 As New StringBuilder

        'PrefList�̃��X�g�������s���{����������擾
        For i As Integer = 0 To PrefList.Count - 1
            strSb2.Append(PrefList(i) & ",")
        Next

        '�R���\�[���ɏo�́i���s�Ń��\�b�h3�Ƃ̊Ԃ�1�s�󂯂�j
        Console.WriteLine(strSb2.ToString() & vbCrLf)
    End Sub

    '���\�b�h3�F�s���{�����X�g�������܂ޓs���{�����R���\�[���o��
    Sub PrefOutput3()
        '�ł��������C���f�b�N�X�ő���܂ޓs���{�����擾
        Dim prefLarge1 = PrefList.Find(Function(s As String) s.Contains("��"c))
        '�R���\�[���ɏo�́i���s��1�s�󂯂�j
        Console.WriteLine(prefLarge1 & vbCrLf)

        '����܂ޓs���{���������_���Ŏ擾����
        '��xFindAll���\�b�h�ŏ����𖞂����S�Ă̗v�f���擾�����̒����烉���_����1�v�f��I���i���Ƒ啪�����Ȃ����ǁE�E�E�j
        '"��"���܂ޑS�Ă̗v�f������
        Dim prefLarge2 = PrefList.FindAll(Function(x As String) x.Contains("��"c))
        '"��"���܂ޕ�����1�ȏ゠��ꍇ
        Try

            Randomize()
            '�����_���N���X�̃C���X�^���X�𐶐�
            Dim rnd As New Random()
            '�����_���ŃC���f�b�N�X���擾
            Dim randomIndex As Integer = rnd.Next(0, prefLarge2.Count)
            '�擾�����C���f�b�N�X�ɕR�Â�����������擾
            Dim randomString As String = prefLarge2(randomIndex)
            '�R���\�[���ɏo�͂���i���s��1�s�󂯂�j
            Console.WriteLine(randomString & vbCrLf)
        Catch ex As Exception
            Console.WriteLine("�����𖞂��������񂪂���܂���B" & vbCrLf)
        End Try

        '���X�g��"��"���܂ޑS�Ă̗v�f���擾���A�R���\�[���ɏo��
        For Each x In prefLarge2
            Console.Write(x & ",")
        Next
        '���s
        Console.WriteLine()
    End Sub
End Module
