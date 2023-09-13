//                            ###ОБМЕННИК###



// int rubToDol = 100;
// int dolToRub = 95;
// string userCurrency;

// Console.WriteLine("Сколько у вас рублей/долларов ?");
// Console.Write("Доллары: ");
// int dolBalance = Convert.ToInt32(Console.ReadLine());
// Console.Write("Рубли: ");
// int rubBalance = Convert.ToInt32(Console.ReadLine());


// while(true) {
//     Console.WriteLine("Выберите действие: ");
//     Console.WriteLine("1 -- Обменять долар на рубли ");
//     Console.WriteLine("2 -- Обменять рубли на долар ");
//     Console.Write("Ваш выбор:");
//     userCurrency = Console.ReadLine();
//     if (userCurrency == "1" || userCurrency == "2"){
//         switch (userCurrency) {
//         case "1":
//             while(true) {
//                 Console.Clear();
//                 Console.ForegroundColor = ConsoleColor.Blue;
//                 Console.Write("Введите кол-во долларов, которое хотите обменять: ");
//                 Console.ForegroundColor = ConsoleColor.White;
                
//                 int userBalanceDol = Convert.ToInt32(Console.ReadLine());

//                 if (userBalanceDol <= dolBalance){
//                     dolBalance -= userBalanceDol;
//                     rubBalance += userBalanceDol * dolToRub;
//                     break;
//                 }

//                 // else{
//                 //     Console.ForegroundColor = ConsoleColor.DarkRed;
//                 //     Console.Write("Вы ввели неправильное число");
//                 //     Console.ForegroundColor = ConsoleColor.White;
//                 // }
//             }
            
//             break;


//         case "2":
//             while(true){
//                 Console.Clear();
//                 Console.ForegroundColor = ConsoleColor.Blue;
//                 Console.Write("Введите кол-во рублей, которое хотите обменять: ");
//                 Console.ForegroundColor = ConsoleColor.White;

//                 int userBalanceRub = Convert.ToInt32(Console.ReadLine());

//                 if (userBalanceRub <= rubBalance){
//                     rubBalance -= userBalanceRub;
//                     dolBalance += userBalanceRub / rubToDol;
//                     break;
//                 }

//                 // else{
//                 //     Console.ForegroundColor = ConsoleColor.DarkRed;
//                 //     Console.Write("Вы ввели неправильное число");
//                 //     Console.ForegroundColor = ConsoleColor.White;
//                 // }
//             }
//             break;

            

//         default:
//             Console.WriteLine("Нет такого варианта ответа");
//             break;

//         }
//         break;
//     }
//     else {
//         Console.Clear();
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.WriteLine("Введите правильное значение");
//         Console.ForegroundColor = ConsoleColor.White;
        
//     }
    
// }



// Console.Write($"На вашем счете ");
// Console.ForegroundColor = ConsoleColor.DarkYellow;
// Console.Write($"{rubBalance} рублей, ");
// Console.ForegroundColor = ConsoleColor.DarkGreen;
// Console.WriteLine($"{dolBalance} долларов");
// Console.ForegroundColor = ConsoleColor.DarkMagenta;
// Console.WriteLine("Спасибо, что выбираете нас!!!");