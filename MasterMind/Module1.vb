Module Mastermind

    Sub Main()
        Dim random As New Random()  ' déclare une variable Classe Random() et une variable Int
        'Inutils Dim c1, c2, c3, c4, c5, c6, c7, c8 As Integer ' rouge 1; jaune 2; vert 3; bleu 4; orange 5; blanc 6; violet 7; marron 8.
        Dim S1, S2, S3, S4 As Integer ' Code position = nbr et valeur = Couleur
        Dim Sr1, Sr2, Sr3, Sr4 As Integer ' code enter par utilisateur en reponse 
        Dim n As Integer 'n le compteur de la Boucle Conditionnel Pour 'For'
        Dim nul, pos As Integer
        '.Next  retourner un nombre aléatoire contenu dans la plage spécifiée
        S1 = random.Next(1, 8)
        S2 = random.Next(1, 8)
        S3 = random.Next(1, 8)
        S4 = random.Next(1, 8)
        'Console.WriteLine("S1:" & S1 & " S2:" & S2 & " S3:" & S3 & " S4:" & S4)
        For n = 1 To 10 Step 1 ' Pour N egale a 1 incrementer (Step = 1:) 1 jusqu'a 10
            If Sr1 = S1 And Sr2 = S2 And Sr3 = S3 And Sr4 = S4 Then
                Console.WriteLine("Bravo, Vous avez Gagner !!")
            Else
                'Verification des possibiliter version longue de S1
                Sr1 = S1


            End If
        Next

        Console.Read()

    End Sub
End Module
