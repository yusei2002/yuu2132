using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("四則演算演算子が1つのみの式を入力してください\r\n文字は、演算子以外入力しないでください\r\nexitと入力すると強制終了、Enterキーを入力で正常に終了します\r\nMキーで計算結果を一つまで記憶できます。RキーでMemoryを呼び出せます");
            Console.ResetColor();
            int q = 1;
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("問題" + q + "\r\n");
                Console.ResetColor();
                q++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("上部の条件に注意して、問題を入力してください\r\n");
                Console.ResetColor();
                /*四則演算符号の1文字目からの場所を取得　IndexOfの出力数＝(文字数-1)*/

                //入力値をxに代入
                string x = (Console.ReadLine()), t3 = "0";
                //変数に値を格納
                /*文字数検出*/
                decimal t4 = 0;
                int l = x.IndexOf("+"), m = x.IndexOf("-"), n = x.IndexOf("*"), o = x.IndexOf("/"), u = x.IndexOf("^"), p = x.IndexOf("M"), r = x.IndexOf("R"), h = x.Length, memory = 0, t = 0;
                //文字数が0の時、ループ解除
                if (h == 0)/*文字数が0の時、while停止*/
                {
                    break;
                }
                if (p != -1)
                {
                    Console.WriteLine("計算結果を変数[memory]に格納します");
                    t = memory;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(memory);
                    Console.WriteLine(p);
                    Console.ResetColor();
                }
                //演算(上から、和・差・積・商)
                else if (l != -1) //変数lに格納される文字式がx内に存在した場合、Ifを実行(以下4組はほぼ同じ)
                {
                    string a = x.Substring(0, l);
                    string b = x.Substring(l + 1);
                    int c = int.Parse(a);
                    int d = int.Parse(b);
                    if (r != -1)
                    {
                        t = memory + d;
                    }
                    else
                    {
                        t = c + d;
                        Console.WriteLine("足し算");
                    }
                }
                else if (m != -1)
                {
                    string a = x.Substring(0, m);
                    string b = x.Substring(m + 1);
                    int c = int.Parse(a);
                    int d = int.Parse(b);
                    if (r != -1)
                    {
                        t = memory - d;
                    }
                    else
                    {
                        t = c - d;
                        Console.WriteLine("引き算");
                    }
                }
                else if (n != -1)
                {
                    string a = x.Substring(0, n);
                    string b = x.Substring(n + 1);
                    int c = int.Parse(a);
                    int d = int.Parse(b);
                    if (r != -1)
                    {
                        t = memory * d;
                    }
                    else
                    {
                        t = c * d;
                        Console.WriteLine("掛け算");
                    }
                }
                else if (o != -1)
                {
                    string a = x.Substring(0, o);
                    string b = x.Substring(o + 1);
                    int c = int.Parse(a);
                    int d = int.Parse(b);
                    decimal e = int.Parse(a);
                    decimal f = int.Parse(b);
                    if (r != -1)
                    {
                        t = memory / d;
                    }
                    else
                    {
                        decimal t1 = 0, t2 = 0;
                        t1 = c / d;
                        t2 = c % d;
                        string t01 = t1.ToString();
                        string t02 = t2.ToString();
                        t3 = t01 + "あまり" + t02;
                        Console.WriteLine("割り算");
                        t4 = e / f;
                    }
                }
                
                else if (u != -1)
                {
                    string a = x.Substring(0, u);
                    string b = x.Substring(u + 1);
                    int c = int.Parse(a);
                    int d = int.Parse(b);
                    int cn = c;
                    while (d > 1)
                    {
                        cn = cn * c;
                        d -= 1;
                    }
                t = cn;
                }
                //識別子が認識されない場合の条件分岐
                if (l + m + n + o + u < -4 || x != "exit")
                {
                    Console.WriteLine("式には必ず一つの識別子を入れてください\r\n答えに0を代入します");
                    /*tに何かが格納されていても、強制的に0に置換する*/
                    t = 0;
                }
                if (x == "Key")
                {
                    ConsoleKeyInfo w;
                    do
                    {
                        Console.WriteLine("\nHキーを押すと電卓に戻ります");
                        w = Console.ReadKey(true);
                        Console.WriteLine(w.Key);
                    } while (w.Key != ConsoleKey.H);
                }
                else if (h == -1)
                {
                    ConsoleKeyInfo w;
                    do
                    {
                        Console.WriteLine("\nHキーを押すとプログラムを終了します");
                        w = Console.ReadKey(true);
                        Console.ReadKey();
                    } while (w.Key == ConsoleKey.H);
                }
                else
                {
                }
                //プロセスを強制終了する
                if (x == "exit")
                {
                    int time = 3;/*残り時間の代入*/
                    Console.WriteLine("システムは3秒後に自動停止します");
                    while (true)//時間が残り0秒でループ終了
                    {
                        //残り時間の計算・表示
                        System.Threading.Thread.Sleep(1000);
                        Console.Beep();
                        Console.WriteLine(time + "秒前");
                        time -= 1;
                        if (time == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Good bye");
                            Console.Beep();
                            System.Threading.Thread.Sleep(500);
                            Environment.Exit(0);//強制終了メソッド
                        }
                        if (time == -1)
                        {
                            break;
                        }
                    }
                }
                //計算結果表示
                if (o == -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\n答え　" + x + "=" + t + "\r\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\n答え　" + x + "=" + t3 + "\r\n");
                    Console.WriteLine("\r\n答え　" + x + "=" + t4 + "\r\n");
                    Console.ResetColor();
                }
            } 
        }
    }
}
