namespace AlgorithmTraining
{
    public class RomainToInteger
    {
        public int ConvertToInt(string romanInt)
        {
            int res = 0;

            for (int i = 0; i < 1; i++)
            {
                int I = 1;
                int V = 5;
                int X = 10;
                int L = 50;
                int C = 100;
                int D = 500;
                int M = 1000;
                int IV = 4;
                int IX = 9;
                int IL = 49;
                int IC = 99;
                int ID = 499;
                int IM = 999;

                //Console.WriteLine("Pleease enter roman nmber:");
                string input = romanInt.ToLower(); /*Console.ReadLine().ToString().ToLower();*/


                if (input.Contains("iv"))
                {
                    res += IV;
                    input = input.Replace("iv", "");
                }

                if (input.Contains("ix"))
                {
                    res += IX;
                    input = input.Replace("ix", "");
                }
                
                if (input.Contains("il"))
                {
                    res += IL;
                    input = input.Replace("il", "");
                }
                
                if (input.Contains("ic"))
                {
                    res += IC;
                    input = input.Replace("ic", "");
                }
                
                if (input.Contains("id"))
                {
                    res += ID;
                    input = input.Replace("id", "");
                }

                if (input.Contains("im"))
                {
                    res += IM;
                    input = input.Replace("im", "");
                }

                for (int j = 0; j < 1; j++)
                {
                    if (input.Contains("i"))
                    {
                        int counter = 0;
                        var TemporailyInput = "";
                        if (input.Contains("v"))
                        {
                            char trimchar = 'v';
                            if (counter == 0)
                            {
                                TemporailyInput = input.Replace("v", "");
                                counter++;
                            }
                            else
                                TemporailyInput = TemporailyInput.Trim(trimchar);
                        }
                        if (input.Contains("x"))
                        {
                            char trimchar = 'x';
                            if (counter == 0)
                            {
                                TemporailyInput = input.Trim(trimchar);
                                counter++;
                            }
                            else
                                TemporailyInput = TemporailyInput.Trim(trimchar);
                        }
                        if (!input.Contains("v") && !input.Contains("x"))
                        {
                            TemporailyInput = input;
                        }
                        for (int k = 0; k < 1; k++)
                        {
                            var p = TemporailyInput.Length;
                            res += I * p;
                        }
                    }

                    if (input.Contains("v"))
                    {
                        int counter = 0;
                        var TemporailyInput = "";
                        if (input.Contains("i"))
                        {
                            char trimchar = 'i';
                            if (counter == 0)
                            {
                                TemporailyInput = input.Trim(trimchar);
                                counter++;
                            }
                            else
                                TemporailyInput = TemporailyInput.Trim(trimchar);
                        }
                        if (input.Contains("x"))
                        {
                            char trimchar = 'x';
                            if (counter == 0)
                            {
                                TemporailyInput = input.Trim(trimchar);
                                counter++;
                            }
                            else
                            {
                                TemporailyInput = TemporailyInput.Trim(trimchar);
                            }
                        }
                        if (!input.Contains("i") && !input.Contains("x"))
                        {
                            TemporailyInput = input;
                        }
                        for (int k = 0; k < 1; k++)
                        {
                            var p = TemporailyInput.Length;
                            res += V * p;
                        }
                    }

                    if (input.Contains("x"))
                    {
                        int counter = 0;
                        var TemporailyInput = "";
                        if (input.Contains("v"))
                        {
                            char trimchar = 'v';
                            if (counter == 0)
                            {
                                TemporailyInput = input.Replace("v", "");
                                counter++;
                            }
                            else
                            {
                                TemporailyInput = TemporailyInput.Trim(trimchar);
                            }
                        }
                        if (input.Contains("i"))
                        {
                            char trimchar = 'i';
                            if (counter == 0)
                            {
                                TemporailyInput = input.Replace("i", "");
                            }
                            else
                            {
                                TemporailyInput = TemporailyInput.Trim(trimchar);
                            }
                        }
                        if (!input.Contains("v") && !input.Contains("i"))
                        {
                            TemporailyInput = input;
                        }
                        for (int k = 0; k < 1; k++)
                        {
                            var p = TemporailyInput.Length;
                            res += X * p;
                        }
                    }
                }
                //Console.WriteLine(res);
            }
            return res;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            RomainToInteger romainToInteger = new RomainToInteger();
            Console.WriteLine(romainToInteger.ConvertToInt("XIV")); 
        }
    }
}