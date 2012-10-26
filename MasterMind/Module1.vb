Module Mastermind

    Sub Main()
        Try

        
        'Initialisation des Vars
        Dim random As New Random()  ' déclare une variable Classe Random() et une variable Int
        'Inutils Dim c1, c2, c3, c4, c5, c6, c7, c8 As Integer ' rouge 1; jaune 2; vert 3; bleu 4; orange 5; blanc 6; violet 7; marron 8.
        Dim S1, S2, S3, S4 As Integer ' Code position = nbr et valeur = Couleur
        Dim Sr1, Sr2, Sr3, Sr4 As Integer ' code enter par utilisateur en reponse 
        Dim n As Integer 'n le compteur de la Boucle Conditionnel Pour 'For'
        Dim nul, pos, bon As Integer
        '.Next  retourner un nombre aléatoire contenu dans la plage spécifiée
        S1 = random.Next(1, 8)
        S2 = random.Next(1, 8)
        S3 = random.Next(1, 8)
        S4 = random.Next(1, 8)
        'Console.WriteLine("S1:" & S1 & " S2:" & S2 & " S3:" & S3 & " S4:" & S4)
        For n = 1 To 10 Step 1 ' Pour N egale a 1 incrementer (Step = 1:) 1 jusqu'a 10
            'Reinitialisation des Vars de Retry
            nul = 0
            pos = 0
            bon = 0
            Console.WriteLine("Entrer la couleur premiere Couleur")
            Sr1 = Console.ReadLine
            Console.WriteLine("Entrer la couleur deuxieme Couleur")
            Sr2 = Console.ReadLine
            Console.WriteLine("Entrer la couleur troisieme Couleur")
            Sr3 = Console.ReadLine
            Console.WriteLine("Entrer la couleur quatrieme Couleur")
            Sr4 = Console.ReadLine

            If Sr1 = S1 And Sr2 = S2 And Sr3 = S3 And Sr4 = S4 Then
                Console.WriteLine("Bravo, Vous avez Gagner !!")
                n = 11
                Exit For
                Exit Sub
            Else
                'Verification des possibiliter version longue de Sr1
                If Sr1 = S1 Then
                    bon = bon + 1
                ElseIf Sr1 <> S1 And (Sr1 = S2 Or Sr1 = S3 Or Sr1 = S4) Then
                    pos = pos + 1
                    ' ElseIf Sr1 <> S1  Sr2 = S2 OR Sr3 = S3 OR Sr4 = S4 Then
                End If
                'Verification des possibiliter version longue de Sr2
                If Sr2 = S2 Then
                    bon = bon + 1
                ElseIf Sr2 <> S2 And (Sr2 = S1 Or Sr2 = S3 Or Sr2 = S4) Then
                    pos = pos + 1
                    ' ElseIf Sr1 <> S1  Sr2 = S2 OR Sr3 = S3 OR Sr4 = S4 Then
                End If
                'Verification des possibiliter version longue de Sr3
                If Sr3 = S3 Then
                    bon = bon + 1
                ElseIf Sr3 <> S3 And (Sr3 = S2 Or Sr3 = S1 Or Sr3 = S4) Then
                    pos = pos + 1
                    ' ElseIf Sr1 <> S1  Sr2 = S2 OR Sr3 = S3 OR Sr4 = S4 Then
                End If
                'Verification des possibiliter version longue de Sr4
                If Sr4 = S4 Then
                    bon = bon + 1
                ElseIf Sr4 <> S4 And (Sr4 = S2 Or Sr4 = S3 Or Sr4 = S1) Then
                    pos = pos + 1
                    ' ElseIf Sr1 <> S1  Sr2 = S2 OR Sr3 = S3 OR Sr4 = S4 Then
                End If

                Console.WriteLine("  Ressayer ")
                Console.WriteLine("  Vous avez " & pos & " de piéce au mauvais endroit,")
                    Console.WriteLine("  ainsi que " & bon & " de piéce bien placés. ")
                Console.Read()
                Console.Clear()
                Console.Read()

            End If
        Next
        If n = 10 Then
            Console.WriteLine("Perdu Vous avait fait plus de 10 essaie")
            Console.Read()
        Else
            Console.Read()
        End If

            Console.Read()
        Catch ex As Exception
            Console.WriteLine("Error:NET 0000x7")
        End Try

    End Sub
End Module
