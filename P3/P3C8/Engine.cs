using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompte
{
    class Engine
    {
        private UserProfile _user;
        private List<string> _menu;
        private ActionHandler _actionHandler;
        private ReadyToTxt _readyToText;

        public Engine(UserProfile user, List<string> menu)
        {
            _user = user;
            _menu = menu;
            _actionHandler = new ActionHandler(user);
            _readyToText = new ReadyToTxt(user);
        }

        public void Program()
        {

            // Run
            Run.PushEnter();

            //Apparition et choix du menu
            string selectMenu;
            while (true)
            {
                selectMenu = ShowMenu.Choice(_menu);

                //Action
                if (selectMenu != "X")
                {
                    _actionHandler.Execute(selectMenu);
                    Console.WriteLine();
                    Run.PushEnter();
                }

                // Création du fichier et fermeture du programme
                else
                {
                    string textList = _readyToText.GeneratTxt(_user.accountCurrent._historyCurrent, _user.accountSavings._historySavings);
                    File.WriteAllText("Transaction.txt", textList);
                    break;
                }


            }
        }
    }
}
