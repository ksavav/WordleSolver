using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WindowsInput;

namespace WordleSolver
{
    public class TypeWord
    {
        public TypeWord(string word)
        {
            InputSimulator isim = new InputSimulator();
            //Thread.Sleep(2000);
            foreach (var l in word)
            {
                switch(l) 
                {
                    case 'A':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_A);
                        break;
                    case 'B':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_B);
                        break;
                    case 'C':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_C);
                        break;
                    case 'D':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_D);
                        break;
                    case 'E':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_E);
                        break;
                    case 'F':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_F);
                        break;
                    case 'G':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_G);
                        break;
                    case 'H':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_H);
                        break;
                    case 'I':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_I);
                        break;
                    case 'J':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_J);
                        break;
                    case 'K':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_K);
                        break;
                    case 'L':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_L);
                        break;
                    case 'M':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_M);
                        break;
                    case 'N':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_N);
                        break;
                    case 'O':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_O);
                        break;
                    case 'P':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_P);
                        break;
                    case 'Q':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Q);
                        break;
                    case 'R':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_R);
                        break;
                    case 'S':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_S);
                        break;
                    case 'T':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_T);
                        break;
                    case 'U':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_U);
                        break;
                    case 'V':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_V);
                        break;
                    case 'W':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_W);
                        break;
                    case 'X':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_X);
                        break;
                    case 'Y':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Y);
                        break;
                    case 'Z':
                        isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Z);
                        break;
                }
                Thread.Sleep(100);
            }

            isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
        }
    }
}
