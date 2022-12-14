
/*=========================================
* Author: Administrator
* DateTime:2017/6/20 18:16:40
* Description:$safeprojectname$
==========================================*/

using UnityEngine;
using UnityEngine.UI;

namespace OrderSystem
{
    public class MainUI : MonoBehaviour
    {
        public MenuView MenuView = null;
        public ClientView ClientView = null;
        public WaiterView WaitView = null;
        public CookView CookView = null;
        public RoomView roomView = null;
        public RoomMenuView RoomMenuView = null;
        public BackgroumdView BackgroumdView = null;

        private void Start()
        {
            ApplicationFacade facade = new ApplicationFacade();
            facade.StartUp(this);
            
        } 
    }
}
