//  public static string FixPhoneNumber(string number)
//         {

//             if (Regex.Match(number, @"^([0-9]{10})$").Success)
//             {
//                 var arr = number.ToCharArray();
//                 for (int i = 0; i < 3; i++)
//                 {
//                     var tmp = arr[i];
//                     arr[i] = arr[i + 3];
//                     arr[i + 3] = tmp;
//                 }

//                 return String.Join("", arr);
//             }

//             if (Regex.Match(number, @"^([0-9]{3}-[0-9]{3}-[0-9]{4})$").Success)
//             {
//                 var strs = number.Split('-');
//                 var temp = strs[0];
//                 strs[0] = strs[1];
//                 strs[1] = temp;
//                 return String.Join("-", strs);
//             }

//             throw new Exception("Incorrect input format");
//         }


//         public static void Main(String[] args)
//         {
//             var res = FixPhoneNumber("10004567890");
//             Console.WriteLine(res);
//         }