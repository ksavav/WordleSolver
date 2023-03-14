using System.Linq;

namespace WordleSolver
{
    public class CheckPresents
    {
        public Dictionary<int, List<char>> yellow_letters = new Dictionary<int, List<char>>();
        public List<char> yellow = new List<char>();
        public char[] green_letters = { '-', '-', '-', '-', '-' };
        public List<char> used_letters = new List<char>();
        public Dictionary<int, List<char>> used_letters_dic = new Dictionary<int, List<char>>();
        bool isOver = false;

        public void FirstWord(string startingWord) 
        {
            yellow_letters.Add(1, new List<char> { });
            yellow_letters.Add(2, new List<char> { });
            yellow_letters.Add(3, new List<char> { });
            yellow_letters.Add(4, new List<char> { });
            yellow_letters.Add(5, new List<char> { });
            used_letters_dic.Add(1, new List<char> { });
            used_letters_dic.Add(2, new List<char> { });
            used_letters_dic.Add(3, new List<char> { });
            used_letters_dic.Add(4, new List<char> { });
            used_letters_dic.Add(5, new List<char> { });
            var t = new TypeWord(startingWord);
        }

        public bool CheckPresentsAndPassNewWordToType(Dictionary<int, string[]> data, List<string> words)
        {
            //yellow = "present"
            //green = "correct"
            //grey = "absent"
            var greenCount = 0;
            foreach (var letter in data)
            {
                if (letter.Value[1] == "correct")
                {
                    green_letters[letter.Key - 1] = char.Parse(letter.Value[0]);
                    //if (yellow.Contains(char.Parse(letter.Value[0]))) yellow.Remove(char.Parse(letter.Value[0]));
                    greenCount++;
                }

                else if (letter.Value[1] == "present")
                {
                    yellow_letters[letter.Key].Add(char.Parse(letter.Value[0]));
                    yellow.Add(char.Parse(letter.Value[0]));
                }

                else
                {
                    used_letters_dic[letter.Key].Add(char.Parse(letter.Value[0]));
                    used_letters.Add(char.Parse(letter.Value[0]));
                }
            }

            if(greenCount < 5)
            {
                var newWord = PickNewWord(words).ToUpper();
                var t = new TypeWord(newWord);
                return false;
            }

            else
            {
                return true;
            }
        }

        public string PickNewWord(List<string> words)
        {
            /*var new_table = from w in xd
                            where w[0] == green_letters[0]
                            select w;*/
                            /*.Concat(from w in words
                                    where w[1].Equals(green_letters[1])
                                    select w)
                            .Concat(from w in words
                                    where w[2].Equals(green_letters[2])
                                    select w)
                            .Concat(from w in words
                                    where w[3].Equals(green_letters[3])
                                    select w)
                            .Concat(from w in words
                                    where w[4].Equals(green_letters[4])
                                    select w).ToList();
                            .Concat(from w in words
                                    where yellow.Contains()
                                    select w);*/

            foreach (var item in words)
            {
                int i = 0;
                int counter = 0;
                var alreadyChecked = new List<char>();


                foreach(var letter in item)
                {
                    if (used_letters_dic[key: i + 1].Contains(letter)) break;
                    if (used_letters.Contains(letter))
                    {
                        if ((yellow.Contains(letter) && counter == 0) || (green_letters.Contains(letter) && !alreadyChecked.Contains(letter))) alreadyChecked.Add(letter); 
                        else break;
                        //if(yellow.Where(x => (x == letter)).Count() > 0 && green_letters.Where(x => (x == letter)).Count() > 0 && item.Where(x => (x == letter)).Count() != 2)
                    }

                    //if (item.Where(x => (x == letter)).Count() < yellow.Where(x => (x == letter)).Count() + green_letters.Where(x => (x == letter)).Count()) break;

                    //if (yellow.Contains(letter) && green_letters.Contains(letter) && counter < 2) counter++;
                    //else break;

                    /*if (yellow.Contains(letter) && green_letters.Contains(letter) && !used_letters.Contains(letter))
                    {
                        if(item.Where(x => (x == letter)).Count() != 2) break;
                    }*/

                    if (green_letters[i] != '-' && letter != green_letters[i]) break;

                    if (yellow_letters[key: i + 1].Contains(letter)) break;

                    i++;
                }

                if (i == 5)
                {
                    var temp_y = new List<char>(yellow);

                    foreach(var l in yellow)
                    {
                        foreach(var x in item)
                        {
                            if (x == l)
                            {
                                try
                                {
                                    temp_y.Remove(l);
                                } catch { };
                            }
                        }
                    }

                    if (temp_y.Count == 0)
                    {
                        words.Remove(item);
                        return(item);
                    }
                }
            }

            return ("error");
        }
    }
}
