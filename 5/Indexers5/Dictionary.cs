using System;

namespace Indexers
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] ukr = new string[5];


        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book";        ukr[0] ="kn";  
            key[1] = "ручка"; value[1] = "pen";         ukr[1]= "r";  
            key[2] = "солнце"; value[2] = "sun";        ukr[2]= "s";  
            key[3] = "яблоко"; value[3] = "apple";      ukr[3]= "ya";  
            key[4] = "стол"; value[4] = "table";        ukr[4]= "st";        
        }

        public string this[string index,string lang]
        {
            get
            {
                if (lang=="rus")
                {
                    for (int i = 0; i < key.Length; i++)
                        if (key[i] == index)
                            return key[i] + " - " + value[i] +" - " + ukr[i];

                    return string.Format("{0} - нет перевода для этого слова.", index);
                }
                else if (lang=="ukr")
                {
                    for (int i = 0; i < ukr.Length; i++)
                        if (ukr[i] == index)
                            return key[i] + " - " + value[i] + " - " + ukr[i];

                    return string.Format("{0} - нет перевода для этого слова.", index);
                }
                else
                {
                    for (int i = 0; i < value.Length; i++)
                        if (value[i] == index)
                            return key[i] + " - " + value[i] + " - " + ukr[i];

                    return string.Format("{0} - нет перевода для этого слова.", index);
                }

                
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }      
    }
}
