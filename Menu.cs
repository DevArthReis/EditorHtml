using System;
namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
            var option = short.Parse(Console.ReadLine());
            HandleMenu(option);
            
        }
        public static void DrawScreen()
        {
            TetoBase();
            Coluna();
            TetoBase();
           
            
            
            
        }
        public static void TetoBase()
        {
            Console.Write("+");
            for (int i = 0; i<=30;i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

        }
        public static void Coluna()
        {
           for(int lines = 0;lines <= 10;lines++)
            {
                Console.Write("|");
                for(int i =0; i<=30;i++)
                {
                    Console.Write(" ");
                    
                }
                Console.Write("|");
                Console.Write("\n");
            } 

        }
        public static void WriteOptions(){
            Console.SetCursorPosition(3,1);
            Console.WriteLine("Editor Html");
            Console.SetCursorPosition(3,2);
            Console.WriteLine("===============");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("Selecione sua opção");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("1- Novo arquivo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("2- Abrir Arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("3-Sair");
            Console.SetCursorPosition(3,9);
            Console.Write("Opção:");

            


        }
        public static void HandleMenu(short option){
            switch(option){
                case 1:Editor.Show();break;
                case 2: Console.WriteLine("\nView");break;
                case 3:
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do progama");
                    Thread.Sleep(1000);         
                    Environment.Exit(3);break;
                }
                default:Show();break;
                
            }
            
        }
    }

}