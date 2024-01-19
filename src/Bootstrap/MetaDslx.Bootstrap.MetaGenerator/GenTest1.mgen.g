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
        #line (8,9)-(8,49) 22 "..\..\..\GenTest1.mgen"
        public string SayHelloSep1(IEnumerable<string> names)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (9,6)-(9,33) 13 "..\..\..\GenTest1.mgen"
            foreach (var name in names)
            #line hidden
            
            {
                __cb.Push("");
                #line (10,9)-(10,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (10,15)-(10,16) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (10,17)-(10,21) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (10,22)-(10,23) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (14,9)-(14,49) 22 "..\..\..\GenTest1.mgen"
        public string SayHelloSep2(IEnumerable<string> names)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first1 = true;
            #line (15,6)-(15,34) 13 "..\..\..\GenTest1.mgen"
            foreach (var name in names) 
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                else
                {
                    __cb.IgnoreLastLineEnd = false;
                    #line (15,44)-(15,53) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write("===\r\n");
                    #line hidden
                    __cb.IgnoreLastLineEnd = true;
                }
                __cb.Push("");
                #line (16,9)-(16,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (16,15)-(16,16) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (16,17)-(16,21) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (16,22)-(16,23) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (20,9)-(20,49) 22 "..\..\..\GenTest1.mgen"
        public string SayHelloSep3(IEnumerable<string> names)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first1 = true;
            #line (21,6)-(21,34) 13 "..\..\..\GenTest1.mgen"
            foreach (var name in names) 
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                    __cb.IgnoreLastLineEnd = false;
                    #line (21,41)-(21,51) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(">>>\r\n" );
                    #line hidden
                    __cb.IgnoreLastLineEnd = true;
                }
                else
                {
                    __cb.IgnoreLastLineEnd = false;
                    #line (21,61)-(21,71) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write("---\r\n" );
                    #line hidden
                    __cb.IgnoreLastLineEnd = true;
                }
                __cb.Push("");
                #line (22,9)-(22,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (22,15)-(22,16) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (22,17)-(22,21) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (22,22)-(22,23) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first1)
            {
                __cb.IgnoreLastLineEnd = false;
                #line (21,77)-(21,86) 28 "..\..\..\GenTest1.mgen"
                __cb.Write("<<<\r\n");
                #line hidden
                __cb.IgnoreLastLineEnd = true;
            }
            return __cb.ToStringAndFree();
        }
        
        #line (26,9)-(26,49) 22 "..\..\..\GenTest1.mgen"
        public string SayHelloSep4(IEnumerable<string> names)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            var __first1 = true;
            foreach (var __item2 in 
            #line (27,6)-(27,12) 13 "..\..\..\GenTest1.mgen"
            names 
            #line hidden
            )
            {
                if (__first1)
                {
                    __first1 = false;
                }
                else
                {
                    __cb.IgnoreLastLineEnd = false;
                    #line (27,22)-(27,26) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(", ");
                    #line hidden
                    __cb.IgnoreLastLineEnd = true;
                }
                __cb.Write({item});
            }
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (30,9)-(30,49) 22 "..\..\..\GenTest1.mgen"
        public string SayHelloSep5(IEnumerable<string> names)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            var __first1 = true;
            foreach (var __item2 in 
            #line (31,6)-(31,12) 13 "..\..\..\GenTest1.mgen"
            names 
            #line hidden
            )
            {
                if (__first1)
                {
                    __first1 = false;
                    __cb.IgnoreLastLineEnd = false;
                    #line (31,19)-(31,23) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write("[" , ignoreLastLineEnd: false);
                    #line hidden
                    __cb.IgnoreLastLineEnd = true;
                }
                else
                {
                    __cb.IgnoreLastLineEnd = false;
                    #line (31,33)-(31,38) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(", " );
                    #line hidden
                    __cb.IgnoreLastLineEnd = true;
                }
                __cb.Write({item});
            }
            if (!__first1)
            {
                __cb.IgnoreLastLineEnd = false;
                #line (31,44)-(31,47) 28 "..\..\..\GenTest1.mgen"
                __cb.Write("]");
                #line hidden
                __cb.IgnoreLastLineEnd = true;
            }
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (34,9)-(34,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello1(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (35,1)-(35,7) 25 "..\..\..\GenTest1.mgen"
            __cb.Write("Hello,");
            #line hidden
            #line (35,7)-(35,8) 25 "..\..\..\GenTest1.mgen"
            __cb.Write(" ");
            #line hidden
            #line (35,9)-(35,13) 24 "..\..\..\GenTest1.mgen"
            __cb.Write(name);
            #line hidden
            #line (35,14)-(35,15) 25 "..\..\..\GenTest1.mgen"
            __cb.Write("!");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (38,9)-(38,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello2(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (39,3)-(39,9) 25 "..\..\..\GenTest1.mgen"
            __cb.Write("Hello,");
            #line hidden
            #line (39,9)-(39,10) 25 "..\..\..\GenTest1.mgen"
            __cb.Write(" ");
            #line hidden
            #line (39,11)-(39,15) 24 "..\..\..\GenTest1.mgen"
            __cb.Write(name);
            #line hidden
            #line (39,16)-(39,17) 25 "..\..\..\GenTest1.mgen"
            __cb.Write("!");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (42,9)-(42,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello3(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (43,4)-(43,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("");
                #line (44,5)-(44,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (44,11)-(44,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (44,13)-(44,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (44,18)-(44,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (48,9)-(48,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello4(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (49,4)-(49,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("");
                #line (50,5)-(50,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (50,11)-(50,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (50,13)-(50,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (50,18)-(50,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("  ");
                #line (51,7)-(51,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (51,14)-(51,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (51,16)-(51,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (51,21)-(51,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (55,9)-(55,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello5(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (56,4)-(56,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("");
                #line (57,5)-(57,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (57,11)-(57,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (57,13)-(57,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (57,18)-(57,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (58,6)-(58,21) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(SayHello1(name));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("  ");
                #line (59,8)-(59,23) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(SayHello2(name));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("  ");
                #line (60,7)-(60,10) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("AAA");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push(" ");
                #line (61,6)-(61,8) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("BB");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (62,5)-(62,7) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("CC");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (63,5)-(63,7) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("aa");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (64,4)-(64,6) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("DD");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (65,3)-(65,5) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("EE");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (69,9)-(69,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello6(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (71,4)-(71,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("    ");
                #line (72,5)-(72,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (72,11)-(72,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (72,13)-(72,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (72,18)-(72,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("      ");
                #line (73,7)-(73,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (73,14)-(73,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (73,16)-(73,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (73,21)-(73,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (77,9)-(77,32) 22 "..\..\..\GenTest1.mgen"
        public string SayHello7(string name)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (79,4)-(79,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("    ");
                #line (80,5)-(80,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (80,11)-(80,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (80,13)-(80,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (80,18)-(80,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("      ");
                #line (81,7)-(81,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (81,14)-(81,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (81,16)-(81,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (81,21)-(81,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (84,4)-(84,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("");
                #line (85,5)-(85,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (85,11)-(85,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (85,13)-(85,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (85,18)-(85,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("  ");
                #line (86,7)-(86,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (86,14)-(86,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (86,16)-(86,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (86,21)-(86,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (89,4)-(89,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("    ");
                #line (90,5)-(90,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (90,11)-(90,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (90,13)-(90,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (90,18)-(90,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("      ");
                #line (91,7)-(91,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (91,14)-(91,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (91,16)-(91,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (91,21)-(91,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (94,4)-(94,24) 13 "..\..\..\GenTest1.mgen"
            if (name != "Alice")
            #line hidden
            
            {
                __cb.Push("");
                #line (95,5)-(95,11) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello,");
                #line hidden
                #line (95,11)-(95,12) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (95,13)-(95,17) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (95,18)-(95,19) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("  ");
                #line (96,7)-(96,14) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("Hello2,");
                #line hidden
                #line (96,14)-(96,15) 29 "..\..\..\GenTest1.mgen"
                __cb.Write(" ");
                #line hidden
                #line (96,16)-(96,20) 28 "..\..\..\GenTest1.mgen"
                __cb.Write(name);
                #line hidden
                #line (96,21)-(96,22) 29 "..\..\..\GenTest1.mgen"
                __cb.Write("!");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            return __cb.ToStringAndFree();
        }
        
        #line (100,9)-(100,61) 22 "..\..\..\GenTest1.mgen"
        public string SayHelloIf(IEnumerable<string> names, bool morning)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (101,4)-(101,31) 13 "..\..\..\GenTest1.mgen"
            foreach (var name in names)
            #line hidden
            
            {
                #line (102,6)-(102,18) 17 "..\..\..\GenTest1.mgen"
                if (morning)
                #line hidden
                
                {
                    __cb.Push("");
                    #line (103,5)-(103,9) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Good");
                    #line hidden
                    #line (103,9)-(103,10) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (103,10)-(103,18) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("morning,");
                    #line hidden
                    #line (103,18)-(103,19) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (103,20)-(103,24) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (103,25)-(103,26) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("!");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (104,6)-(104,10) 17 "..\..\..\GenTest1.mgen"
                else
                #line hidden
                
                {
                    __cb.Push("");
                    #line (105,5)-(105,9) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Good");
                    #line hidden
                    #line (105,9)-(105,10) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (105,10)-(105,18) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("evening,");
                    #line hidden
                    #line (105,18)-(105,19) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (105,20)-(105,24) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (105,25)-(105,26) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("!");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
            }
            return __cb.ToStringAndFree();
        }
        
        #line (110,9)-(110,43) 22 "..\..\..\GenTest1.mgen"
        public string SayHelloSC(string name, int time)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (112,4)-(112,17) 13 "..\..\..\GenTest1.mgen"
            switch (time)
            #line hidden
            
            {
                #line (113,6)-(113,13) 17 "..\..\..\GenTest1.mgen"
                case 1:
                #line hidden
                
                {
                    __cb.Push("      ");
                    #line (114,7)-(114,11) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Good");
                    #line hidden
                    #line (114,11)-(114,12) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (114,12)-(114,20) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("morning,");
                    #line hidden
                    #line (114,20)-(114,21) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (114,22)-(114,26) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (114,27)-(114,28) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("!");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    break;
                }
                #line (115,6)-(115,21) 17 "..\..\..\GenTest1.mgen"
                case 2: case 3:
                #line hidden
                
                {
                    __cb.Push("      ");
                    #line (116,7)-(116,11) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Good");
                    #line hidden
                    #line (116,11)-(116,12) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (116,12)-(116,22) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("afternoon,");
                    #line hidden
                    #line (116,22)-(116,23) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (116,24)-(116,28) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (116,29)-(116,30) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("!");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    break;
                }
                #line (117,6)-(117,13) 17 "..\..\..\GenTest1.mgen"
                case 4:
                #line hidden
                
                {
                    break;
                }
                #line (117,15)-(117,22) 17 "..\..\..\GenTest1.mgen"
                case 5:
                #line hidden
                
                {
                    __cb.Push("      ");
                    #line (118,7)-(118,11) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Good");
                    #line hidden
                    #line (118,11)-(118,12) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (118,12)-(118,20) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("evening,");
                    #line hidden
                    #line (118,20)-(118,21) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (118,22)-(118,26) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (118,27)-(118,28) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("!");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    break;
                }
                #line (119,6)-(119,14) 17 "..\..\..\GenTest1.mgen"
                default:
                #line hidden
                
                {
                    __cb.Push("      ");
                    #line (120,7)-(120,13) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write("Hello,");
                    #line hidden
                    #line (120,13)-(120,14) 33 "..\..\..\GenTest1.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,15)-(120,19) 32 "..\..\..\GenTest1.mgen"
                    __cb.Write(name);
                    #line hidden
                    #line (120,20)-(120,21) 33 "..\..\..\GenTest1.mgen"
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