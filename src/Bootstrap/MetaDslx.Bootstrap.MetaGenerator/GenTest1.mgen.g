#line (1,10)-(1,43) 10 "..\..\..\GenTest1.mgen"
namespace MetaDslx.Bootstrap.MetaGenerator
#line hidden

{
    #line (3,1)-(3,6) 5 "..\..\..\GenTest1.mgen"
    using
    #line hidden
    global::
    #line (3,7)-(3,13) 13 "..\..\..\GenTest1.mgen"
    System;
    #line hidden
    #line (4,1)-(4,6) 5 "..\..\..\GenTest1.mgen"
    using
    #line hidden
    global::
    #line (4,7)-(4,18) 13 "..\..\..\GenTest1.mgen"
    System.Linq;
    #line hidden
    
    #line (6,10)-(6,19) 25 "..\..\..\GenTest1.mgen"
    public partial class GenTest1
    #line hidden
    {
        #line (8,9)-(8,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello1(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (9,1)-(9,7) 25 "..\..\..\GenTest1.mgen"
            __cb.Write("Hello,");
            #line hidden
            #line (9,7)-(9,8) 25 "..\..\..\GenTest1.mgen"
            __cb.Write(" ");
            #line hidden
            #line (9,9)-(9,13) 24 "..\..\..\GenTest1.mgen"
            __cb.Write(name);
            #line hidden
            #line (9,14)-(9,15) 25 "..\..\..\GenTest1.mgen"
            __cb.Write("!");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (12,9)-(12,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello2(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (13,3)-(13,9) 25 "..\..\..\GenTest1.mgen"
            __cb.Write("Hello,");
            #line hidden
            #line (13,9)-(13,10) 25 "..\..\..\GenTest1.mgen"
            __cb.Write(" ");
            #line hidden
            #line (13,11)-(13,15) 24 "..\..\..\GenTest1.mgen"
            __cb.Write(name);
            #line hidden
            #line (13,16)-(13,17) 25 "..\..\..\GenTest1.mgen"
            __cb.Write("!");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (16,9)-(16,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello3(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (17,4)-(17,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("");
                #line (18,5)-(18,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (18,11)-(18,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (18,13)-(18,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (18,18)-(18,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (22,9)-(22,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello4(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (23,4)-(23,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("");
                #line (24,5)-(24,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (24,11)-(24,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (24,13)-(24,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (24,18)-(24,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("  ");
                #line (25,7)-(25,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (25,14)-(25,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (25,16)-(25,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (25,21)-(25,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (29,9)-(29,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello5(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (30,4)-(30,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("");
                #line (31,5)-(31,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (31,11)-(31,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (31,13)-(31,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (31,18)-(31,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (32,6)-(32,21) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(SayHello1(name));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("  ");
                #line (33,8)-(33,23) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(SayHello2(name));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("  ");
                #line (34,7)-(34,10) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("AAA");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push(" ");
                #line (35,6)-(35,8) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("BB");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (36,5)-(36,7) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("CC");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (37,5)-(37,7) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("aa");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (38,4)-(38,6) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("DD");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (39,3)-(39,5) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("EE");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (43,9)-(43,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello6(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (45,4)-(45,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("    ");
                #line (46,5)-(46,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (46,11)-(46,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (46,13)-(46,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (46,18)-(46,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("      ");
                #line (47,7)-(47,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (47,14)-(47,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (47,16)-(47,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (47,21)-(47,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (51,9)-(51,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello7(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (53,4)-(53,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("    ");
                #line (54,5)-(54,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (54,11)-(54,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (54,13)-(54,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (54,18)-(54,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("      ");
                #line (55,7)-(55,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (55,14)-(55,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (55,16)-(55,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (55,21)-(55,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (58,4)-(58,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("");
                #line (59,5)-(59,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (59,11)-(59,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (59,13)-(59,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (59,18)-(59,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("  ");
                #line (60,7)-(60,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (60,14)-(60,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (60,16)-(60,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (60,21)-(60,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (63,4)-(63,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("    ");
                #line (64,5)-(64,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (64,11)-(64,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (64,13)-(64,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (64,18)-(64,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("      ");
                #line (65,7)-(65,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (65,14)-(65,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (65,16)-(65,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (65,21)-(65,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (68,4)-(68,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("");
                #line (69,5)-(69,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (69,11)-(69,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (69,13)-(69,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (69,18)-(69,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("  ");
                #line (70,7)-(70,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (70,14)-(70,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (70,16)-(70,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (70,21)-(70,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (74,9)-(74,61) 22 "..\..\..\GenTest1.mgen"
        public string SayHelloIf(IEnumerable<string> names, bool morning)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (75,4)-(75,31) 13 "..\..\..\GenTest1.mgen"
            foreach (var name in names)
            #line hidden
            
            {
                #line (76,6)-(76,18) 17 "..\..\..\GenTest1.mgen"
                if (morning)
                #line hidden
                
                {
                    __cb.Push("");
                    #line (77,5)-(77,9) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Good");
                    #line hidden
                    #line (77,9)-(77,10) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (77,10)-(77,18) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("morning,");
                    #line hidden
                    #line (77,18)-(77,19) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (77,20)-(77,24) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (77,25)-(77,26) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("!");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (78,6)-(78,10) 17 "..\..\..\GenTest1.mgen"
                else
                #line hidden
                
                {
                    __cb.Push("");
                    #line (79,5)-(79,9) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Good");
                    #line hidden
                    #line (79,9)-(79,10) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (79,10)-(79,18) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("evening,");
                    #line hidden
                    #line (79,18)-(79,19) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (79,20)-(79,24) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (79,25)-(79,26) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("!");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
            }
            return __cb.ToStringAndFree();
        }
        
        #line (84,9)-(84,43) 22 "..\..\..\GenTest1.mgen"
        public string SayHelloSC(string name, int time)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (86,4)-(86,17) 13 "..\..\..\GenTest1.mgen"
            switch (time)
            #line hidden
            
            {
                #line (87,6)-(87,13) 17 "..\..\..\GenTest1.mgen"
                case 1:
                #line hidden
                
                {
                    __cb.Push("      ");
                    #line (88,7)-(88,11) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Good");
                    #line hidden
                    #line (88,11)-(88,12) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,12)-(88,20) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("morning,");
                    #line hidden
                    #line (88,20)-(88,21) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,22)-(88,26) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (88,27)-(88,28) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("!");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    break;
                }
                #line (89,6)-(89,21) 17 "..\..\..\GenTest1.mgen"
                case 2: case 3:
                #line hidden
                
                {
                    __cb.Push("      ");
                    #line (90,7)-(90,11) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Good");
                    #line hidden
                    #line (90,11)-(90,12) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,12)-(90,22) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("afternoon,");
                    #line hidden
                    #line (90,22)-(90,23) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,24)-(90,28) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (90,29)-(90,30) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("!");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    break;
                }
                #line (91,6)-(91,13) 17 "..\..\..\GenTest1.mgen"
                case 4:
                #line hidden
                
                {
                    break;
                }
                #line (91,15)-(91,22) 17 "..\..\..\GenTest1.mgen"
                case 5:
                #line hidden
                
                {
                    __cb.Push("      ");
                    #line (92,7)-(92,11) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Good");
                    #line hidden
                    #line (92,11)-(92,12) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (92,12)-(92,20) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("evening,");
                    #line hidden
                    #line (92,20)-(92,21) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (92,22)-(92,26) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (92,27)-(92,28) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("!");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    break;
                }
                #line (93,6)-(93,14) 17 "..\..\..\GenTest1.mgen"
                default:
                #line hidden
                
                {
                    __cb.Push("      ");
                    #line (94,7)-(94,13) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Hello,");
                    #line hidden
                    #line (94,13)-(94,14) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (94,15)-(94,19) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (94,20)-(94,21) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("!");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    break;
                }
            }
            return __cb.ToStringAndFree();
        }
        
    }}