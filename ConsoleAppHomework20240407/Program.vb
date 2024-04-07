Imports System
Imports System.Security.Cryptography.X509Certificates
Imports System.Text

Module Program

    Sub Main(args As String())
        'メソッド1を呼び出し実行
        PrefOutput1()
        'メソッド2を呼び出し実行
        PrefOutput2()
        'メソッド3を呼び出し実行
        PrefOutput3()
    End Sub

    'メソッド1：都道府県をカンマでつなげた文字列をコンソールに出力
    Sub PrefOutput1()
        'StringBuilderクラスオブジェクトを生成
        Dim strSb1 As New System.Text.StringBuilder

        'PrefArr配列の配列分だけ都道府県文字列を取得
        For i = 0 To PrefArr.GetUpperBound(0)
            strSb1.Append(PrefArr(i) & ",")
        Next

        'コンソールに出力（改行でメソッド2との間に1行空ける）
        Console.WriteLine(strSb1.ToString() & vbCrLf)
    End Sub

    'メソッド2：List(Of String)の都道府県リストを使ってカンマで繋げた文字列を作成
    Sub PrefOutput2()
        'StringBuilderクラスオブジェクトを生成
        Dim strSb2 As New StringBuilder

        'PrefListのリスト分だけ都道府県文字列を取得
        For i As Integer = 0 To PrefList.Count - 1
            strSb2.Append(PrefList(i) & ",")
        Next

        'コンソールに出力（改行でメソッド3との間に1行空ける）
        Console.WriteLine(strSb2.ToString() & vbCrLf)
    End Sub

    'メソッド3：都道府県リストから大を含む都道府県をコンソール出力
    Sub PrefOutput3()
        '最も小さいインデックスで大を含む都道府県を取得
        Dim prefLarge1 = PrefList.Find(Function(s As String) s.Contains("大"c))
        'コンソールに出力（改行で1行空ける）
        Console.WriteLine(prefLarge1 & vbCrLf)

        '大を含む都道府県をランダムで取得する
        '一度FindAllメソッドで条件を満たす全ての要素を取得しその中からランダムで1つ要素を選択（大阪と大分しかないけど・・・）
        '"大"を含む全ての要素を検索
        Dim prefLarge2 = PrefList.FindAll(Function(x As String) x.Contains("大"c))
        '"大"を含む文字が1つ以上ある場合
        Try

            Randomize()
            'ランダムクラスのインスタンスを生成
            Dim rnd As New Random()
            'ランダムでインデックスを取得
            Dim randomIndex As Integer = rnd.Next(0, prefLarge2.Count)
            '取得したインデックスに紐づいた文字列を取得
            Dim randomString As String = prefLarge2(randomIndex)
            'コンソールに出力する（改行で1行空ける）
            Console.WriteLine(randomString & vbCrLf)
        Catch ex As Exception
            Console.WriteLine("条件を満たす文字列がありません。" & vbCrLf)
        End Try

        'リストの"大"を含む全ての要素を取得し、コンソールに出力
        For Each x In prefLarge2
            Console.Write(x & ",")
        Next
        '改行
        Console.WriteLine()
    End Sub
End Module
