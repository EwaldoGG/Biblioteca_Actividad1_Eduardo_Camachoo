Imports System

Module LibraryApp
    Dim miLibro As New Librobl("En honor al Esp�ritu Santo", "Cash Luna")
    Sub Main()
        Dim opcion As Integer

        Do
            Console.Clear()
            Console.WriteLine("=== Librer�a Virtual ===")
            Console.WriteLine("1. Prestar libro")
            Console.WriteLine("2. Devolver libro")
            Console.WriteLine("3. Salir")
            Console.Write("Seleccione una opci�n: ")

            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 1
                    PrestarLibro()
                Case 2
                    DevolverLibro()
                Case 3
                    Console.WriteLine("Saliendo del sistema...")
                Case Else
                    Console.WriteLine("Opci�n no v�lida.")
            End Select

            Console.WriteLine("Presione una tecla para continuar...")
            Console.ReadKey()
        Loop While opcion <> 3
    End Sub

    Sub PrestarLibro()
        Console.WriteLine(miLibro.Prestar())
    End Sub

    Sub DevolverLibro()
        Console.WriteLine(miLibro.Devolver())
    End Sub
End Module
