using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KompasTabl.Models
{
  public  class TableRow
    {
        string choiceAbstraction;
        string accesText;
        string text = string.Empty;

        int choise=0;
        int acces = 0;

        public TableRow() { }
        public TableRow(int choise, int acces, string text)
        {
            Choise = choise;
            Acces = acces;
            Text = text;
        }

        //свойства
        public string ChoiceAbstraction
        { get => choiceAbstraction; set => choiceAbstraction = value; }
        public string AccesText
        { get => accesText; set => accesText = value; }
        public string Text 
        { get => text; set => text = value; }
        public int Choise { get => choise; set => choise = value; }
        public int Acces { get => acces; set => acces = value; }

        /// <summary>
        /// создает текст для таблицы
        /// </summary>
        /// <param name="acces">переменная из столбца допуск</param>
        /// <param name="text">переменная из столбца текст</param>
        /// <returns></returns>
        public string CreateTabelRow( int acces, string text)
        {
            string result;
            Text = text;
            int caseAcces = 0;

            if(acces == 0 || acces == 1 || acces ==2)
            {
                caseAcces = acces;
            }
            else
            {
                caseAcces = 1;
            }
            switch(caseAcces)
            {
                case 0:
                    AccesText = "+ ";
                    break;
                case 1:
                    AccesText = "- ";
                    break;
                case 2:
                    AccesText = "(protect) ";
                    break;

            }
            result = AccesText + Text;
            return result;
        }
        /// <summary>
        /// метод делает наклонный текст
        /// </summary>
        /// <param name="choes">переменная из колонки статик абстракт</param>
        /// <returns></returns>
        public int ChoesAbstract(int choes)
        {
            int result=0x80;
            if(choes==1)
            {
                result = 0;
            }

            return result;
        }

        /// <summary>
        /// метод проверяет все не заполненные строки в листе
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        public bool IsRowNool (List<TableRow> rows)
        {
            bool result = false;
            foreach(var i in rows)
            {
                if(i.text != "")
                { 
                    result = false;
                    break;
                }
                else
                {
                     result = true;
                }
                
            }

            return result;
        }
    }
}
