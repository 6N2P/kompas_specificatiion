using Kompas6API5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using KompasTabl.Models;

namespace KompasTabl.Presentor
{
    class Presentor
    {
        KompasObject kompas;
        private IForm1 form;


        public Presentor(IForm1 form)
        {
            this.form = form;
            form.CreateTabl += Form_CreateTabl;
        }

        private void Form_CreateTabl(object sender, EventArgs e)
        {
            //получаю все строки
            TableRow rowNameClas = new TableRow(form.choiseAbstractClas, form.accsesClad, form.NameClas);

            TableRow rowValue1 = new TableRow(form.choiseAbstractValue1, form.accsesValue1, form.NameValue1);
            TableRow rowValue2 = new TableRow(form.choiseAbstractValue2, form.accsesValue2, form.NameValue2);
            TableRow rowValue3 = new TableRow(form.choiseAbstractValue3, form.accsesValue3, form.NameValue3);
            TableRow rowValue4 = new TableRow(form.choiseAbstractValue4, form.accsesValue4, form.NameValue4);
            TableRow rowValue5 = new TableRow(form.choiseAbstractValue5, form.accsesValue5, form.NameValue5);

            List<TableRow> valueList = new List<TableRow>();
            valueList.Add(rowValue1);
            valueList.Add(rowValue2);
            valueList.Add(rowValue3);
            valueList.Add(rowValue4);
            valueList.Add(rowValue5);

            TableRow rowConstr1 = new TableRow(form.choiseAbstractConstructor1, form.accsesConstructor1, form.NameConstructor1);
            TableRow rowConstr2 = new TableRow(form.choiseAbstractConstructor2, form.accsesConstructor2, form.NameConstructor2);
            TableRow rowConstr3 = new TableRow(form.choiseAbstractConstructor3, form.accsesConstructor3, form.NameConstructor3);

            List<TableRow> constrList = new List<TableRow>();
            constrList.Add(rowConstr1);
            constrList.Add(rowConstr2);
            constrList.Add(rowConstr3);

            TableRow rowInterface1 = new TableRow(form.choiseAbstractInterfeice1, form.accsesInterfeice1, form.NameInterfeice1);
            TableRow rowInterface2 = new TableRow(form.choiseAbstractInterfeice2, form.accsesInterfeice2, form.NameInterfeice2);
            TableRow rowInterface3 = new TableRow(form.choiseAbstractInterfeice3, form.accsesInterfeice3, form.NameInterfeice3);
            TableRow rowInterface4 = new TableRow(form.choiseAbstractInterfeice4, form.accsesInterfeice4, form.NameInterfeice4);
            TableRow rowInterface5 = new TableRow(form.choiseAbstractInterfeice5, form.accsesInterfeice5, form.NameInterfeice5);
            TableRow rowInterface6 = new TableRow(form.choiseAbstractInterfeice6, form.accsesInterfeice6, form.NameInterfeice6);
            TableRow rowInterface7 = new TableRow(form.choiseAbstractInterfeice7, form.accsesInterfeice7, form.NameInterfeice7);
            TableRow rowInterface8 = new TableRow(form.choiseAbstractInterfeice8, form.accsesInterfeice8, form.NameInterfeice8);
            TableRow rowInterface9 = new TableRow(form.choiseAbstractInterfeice9, form.accsesInterfeice9, form.NameInterfeice9);
            TableRow rowInterface10 = new TableRow(form.choiseAbstractInterfeice10, form.accsesInterfeice10, form.NameInterfeice10);

            List<TableRow> interfaceList = new List<TableRow>();
            interfaceList.Add(rowInterface1);
            interfaceList.Add(rowInterface2);
            interfaceList.Add(rowInterface3);
            interfaceList.Add(rowInterface4);
            interfaceList.Add(rowInterface5);
            interfaceList.Add(rowInterface6);
            interfaceList.Add(rowInterface7);
            interfaceList.Add(rowInterface8);
            interfaceList.Add(rowInterface9);
            interfaceList.Add(rowInterface10);


            int cauntRow = 2;
            
            int cauntChekRou = cauntRow;

            //подключаюсь к документу компаса
            kompas = (KompasObject)Marshal.GetActiveObject("KOMPAS.Application.5");
            ksDocument2D doc = (ksDocument2D)kompas.ActiveDocument2D();

            int heighTabl = 0;
            int heightLine = 6;
            int width = 120;
            int firstPointY = 50;

            //создаю таблицу
            doc.ksTable();
            //создаю первую строку для класса

            string text = rowNameClas.CreateTabelRow(rowNameClas.Acces, rowNameClas.Text);
            int naclon = rowNameClas.ChoesAbstract(rowNameClas.Choise);

            doc.ksLineSeg(50, firstPointY, width, firstPointY, 1);
            doc.ksText(52, 48, 0, 4, 1, naclon, text);
            doc.ksLineSeg(50, firstPointY - heightLine, width, firstPointY - heightLine, 1);
            //записываю высату таблицы на данный момент
            heighTabl = heighTabl + heightLine;

            //проверяю есть ли заполенные стороки со значениями
            if (rowNameClas.IsRowNool(valueList) != true)
            {
                doc.ksText(52, firstPointY - heighTabl - 2, 0, 4, 1, 0x80, "<<value>>");
                heighTabl = heighTabl + heightLine;
                //создаю строки со значениями
                foreach (var i in valueList)
                {
                    if (i.Text != "")
                    {
                        TableRow valueRow = new TableRow();
                        valueRow = i;

                        string text1 = valueRow.CreateTabelRow(valueRow.Acces, valueRow.Text);
                        int naclon1 = valueRow.ChoesAbstract(valueRow.Choise);

                        doc.ksText(52, firstPointY - heighTabl - 2, 0, 4, 1, naclon1, text1);

                          doc.ksLineSeg(50, firstPointY - heighTabl, width, firstPointY - heighTabl, 2);
                        heighTabl = heighTabl + heightLine;
                    }
                }
                                
                doc.ksLineSeg(50, firstPointY - heighTabl, width, firstPointY - heighTabl, 1);
             //   heighTabl = heighTabl + heightLine;
            }
            //else
            //{
            //    doc.ksText(52, firstPointY - heighTabl - 2, 0, 4, 1, 0, "");
            //    doc.ksLineSeg(50, firstPointY - heighTabl, width, firstPointY - heighTabl, 1);
            //    heighTabl = heighTabl + heightLine;
            //}
            //проверяет есть ли значения в полях конструктора
            if (rowNameClas.IsRowNool(constrList) != true)
            {
                //создаёт строки конструктора
                doc.ksText(52, firstPointY - heighTabl - 2, 0, 4, 1, 0x80, "<<constructor>>");
                heighTabl = heighTabl + heightLine;

                foreach (var i in constrList)
                {
                    if (i.Text != "")
                    {
                        TableRow constrRow = new TableRow();
                        constrRow = i;

                        string text1 = constrRow.CreateTabelRow(constrRow.Acces, constrRow.Text);
                        int naclon1 = constrRow.ChoesAbstract(constrRow.Choise);

                        doc.ksText(52, firstPointY - heighTabl - 2, 0, 4, 1, naclon1, text1);

                          doc.ksLineSeg(50, firstPointY - heighTabl, width, firstPointY - heighTabl, 2);
                        heighTabl = heighTabl + heightLine;
                    }
                }
                doc.ksLineSeg(50, firstPointY - heighTabl, width, firstPointY - heighTabl, 1);

            }

            if (rowNameClas.IsRowNool(interfaceList) != true)
            {
                //создаёт строки интерфейса
                doc.ksText(52, firstPointY - heighTabl - 2, 0, 4, 1, 0x80, "<<interfase>>");
                heighTabl = heighTabl + heightLine;

                foreach (var i in interfaceList)
                {
                    if (i.Text != "")
                    {
                        TableRow constrRow = new TableRow();
                        constrRow = i;

                        string text1 = constrRow.CreateTabelRow(constrRow.Acces, constrRow.Text);
                        int naclon1 = constrRow.ChoesAbstract(constrRow.Choise);

                        doc.ksText(52, firstPointY - heighTabl - 2, 0, 4, 1, naclon1, text1);

                          doc.ksLineSeg(50, firstPointY - heighTabl, width, firstPointY - heighTabl, 2);
                        heighTabl = heighTabl + heightLine;
                    }
                }
                doc.ksLineSeg(50, firstPointY - heighTabl, width, firstPointY - heighTabl, 1);
            }
                        
            //боковые линии таблицы
            doc.ksLineSeg(50, firstPointY, 50, firstPointY - heighTabl, 1);
            doc.ksLineSeg(width, firstPointY, width, firstPointY - heighTabl, 1);


            doc.ksEndObj();
        }


    }
}
