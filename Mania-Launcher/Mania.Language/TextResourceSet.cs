﻿using System.Collections.Generic;

namespace Mania.Language
{

    public class TextResourceSet1 : TextResourceSetBase
    {
        public TextResourceSet1()
        {
            var ptBRTextResources = new Dictionary<TextResource, string>
            {
        { TextResource.PLAY, ptBR.PLAY },
        { TextResource.STARTING, ptBR.STARTING },
        { TextResource.ERROR_BATTLENET, ptBR.ERROR_BATTLENET },
        { TextResource.ONLINE, ptBR.ONLINE },
        { TextResource.OFFLINE, ptBR.OFFLINE },
        { TextResource.UPDATING, ptBR.UPDATING },
        { TextResource.DOWNLOAD_STATUS, ptBR.DOWNLOAD_STATUS },
        { TextResource.REGISTER, ptBR.REGISTER },
        { TextResource.ACCOUNT, ptBR.ACCOUNT },
        { TextResource.FORUM, ptBR.FORUM },
        { TextResource.REALMLISTBTN, ptBR.REALMLISTBTN },
        { TextResource.CLEARCACHEBTN, ptBR.CLEARCACHEBTN },
        { TextResource.HOTNEWS, ptBR.HOTNEWS },
        { TextResource.UPDSTART, ptBR.UPDSTART },
        { TextResource.UPDCOMPLETE, ptBR.UPDCOMPLETE },
        { TextResource.NEWSBANNERERROR, ptBR.NEWSBANNERERROR },
        { TextResource.EXENOTFOUND, ptBR.EXENOTFOUND },
        { TextResource.ERRORSTARTINGGAME, ptBR.ERRORSTARTINGGAME },
        { TextResource.CACHEOK, ptBR.CACHEOK },
        { TextResource.CACHENO, ptBR.CACHENO },
        { TextResource.REALMLISTOK, ptBR.REALMLISTOK },
        { TextResource.REALMLISTNO, ptBR.REALMLISTNO },
        { TextResource.CHARINFOERR, ptBR.CHARINFOERR },
        { TextResource.CHARLISTERR, ptBR.CHARLISTERR },
        { TextResource.SETTINGOK, ptBR.SETTINGOK },
        { TextResource.SETTINGERR, ptBR.SETTINGERR },
        { TextResource.TOOLSTATONLINE, ptBR.TOOLSTATONLINE },
        { TextResource.TOOLSETTINGS, ptBR.TOOLSETTINGS },
        { TextResource.TOOLMINI, ptBR.TOOLMINI },
        { TextResource.TOOLCLOSE, ptBR.TOOLCLOSE },
        { TextResource.SAVEBTN, ptBR.SAVEBTN },
        { TextResource.SETTLABEL1, ptBR.SETTLABEL1 },
        { TextResource.SETTLABEL2, ptBR.SETTLABEL2 },
        { TextResource.LABELAUTOLOG, ptBR.LABELAUTOLOG },
        { TextResource.SETLOGIN, ptBR.SETLOGIN },
        { TextResource.SETPASSWORD, ptBR.SETPASSWORD },
        { TextResource.SETHEADER, ptBR.SETHEADER },
        { TextResource.ENTLOG, ptBR.ENTLOG },
        { TextResource.ENTPASS, ptBR.ENTPASS },
        { TextResource.TABMENU, ptBR.TABMENU },
        { TextResource.TABMENU1, ptBR.TABMENU1 },
        { TextResource.TABMENU2, ptBR.TABMENU2 },
        { TextResource.CLEARTOOLTIP, ptBR.CLEARTOOLTIP },
        { TextResource.CHANGELOC, ptBR.CHANGELOC },
        { TextResource.ENTWOWEXE, ptBR.ENTWOWEXE },
        { TextResource.BTNCLEAR, ptBR.BTNCLEAR },
        { TextResource.EXITBTN, ptBR.EXITBTN },
        { TextResource.SEARCHLABEL, ptBR.SEARCHLABEL },
        { TextResource.SEARCHCHAR, ptBR.SEARCHCHAR },
        { TextResource.HIDELIST, ptBR.HIDELIST },
        { TextResource.SHOWLIST, ptBR.SHOWLIST },
        { TextResource.DOUBLECLICKCHAR, ptBR.DOUBLECLICKCHAR },
        { TextResource.GENINFO, ptBR.GENINFO },
        { TextResource.LEVELCHAR, ptBR.LEVELCHAR },
        { TextResource.FACTIONCHAR, ptBR.FACTIONCHAR },
        { TextResource.CLASSCHAR, ptBR.CLASSCHAR },
        { TextResource.PVPCHAR, ptBR.PVPCHAR },
        { TextResource.QUESTCHAR, ptBR.QUESTCHAR },
        { TextResource.ERRORLOGIN, ptBR.ERRORLOGIN },
        { TextResource.NOTLOGORPASS, ptBR.NOTLOGORPASS },
        { TextResource.LOGINBTN, ptBR.LOGINBTN },
        { TextResource.FORGOTPWD, ptBR.FORGOTPWD },
        { TextResource.REMEMBER, ptBR.REMEMBER },
        { TextResource.NOTACC, ptBR.NOTACC },
        { TextResource.CREATEACC, ptBR.CREATEACC },
        { TextResource.ENTERLOGIN, ptBR.ENTERLOGIN },
        { TextResource.LOGINEMPTY, ptBR.LOGINEMPTY },
        { TextResource.PASSEMPTY, ptBR.PASSEMPTY },
        { TextResource.RESETSETT, ptBR.RESETSETT },
        { TextResource.CANCELBTN, ptBR.CANCELBTN },
        { TextResource.POPUPMSG, ptBR.POPUPMSG },
        { TextResource.RESETMSG, ptBR.RESETMSG },
        { TextResource.RESETMSGERR, ptBR.RESETMSGERR },
        { TextResource.RESTARTBTN, ptBR.RESTARTBTN },
        { TextResource.RESTARTLATERBTN, ptBR.RESTARTLATERBTN },
        { TextResource.POPUPMSGRESTART, ptBR.POPUPMSGRESTART },
        { TextResource.WELCBLOCK, ptBR.WELCBLOCK },
        { TextResource.WELCDESCR, ptBR.WELCDESCR },
        { TextResource.WELCBTN, ptBR.WELCBTN },
        { TextResource.WELCBTNSET, ptBR.WELCBTNSET },
        { TextResource.GAMESBTN, ptBR.GAMESBTN },
        { TextResource.NEWSBTN, ptBR.NEWSBTN },
        { TextResource.ACCMENU, ptBR.ACCMENU },
        { TextResource.FORUMMENU, ptBR.FORUMMENU },
        { TextResource.SETTMENU, ptBR.SETTMENU },
        { TextResource.RELOGMENU, ptBR.RELOGMENU },
        { TextResource.EXITMENU, ptBR.EXITMENU },
        { TextResource.LANGUAGEMENU, ptBR.LANGUAGEMENU },
        { TextResource.GENERALSETLABEL, ptBR.GENERALSETLABEL },
        { TextResource.COPYAPP, ptBR.COPYAPP },
        { TextResource.ALLREALMS, ptBR.ALLREALMS },
        { TextResource.CONFTEXT, ptBR.CONFTEXT },
        { TextResource.OPENGAMECONF, ptBR.OPENGAMECONF },
        { TextResource.SETTINGSBTN, ptBR.SETTINGSBTN },
        { TextResource.SHOPBTN, ptBR.SHOPBTN },
        { TextResource.FORUMBTN, ptBR.FORUMBTN },
        { TextResource.CHANGEGAMELANG, ptBR.CHANGEGAMELANG },
        { TextResource.ERRORLOGINORPASSWORD, ptBR.ERRORLOGINORPASSWORD }

        };

            var enUSTextResources = new Dictionary<TextResource, string>
            {
        { TextResource.PLAY, enUS.PLAY },
        { TextResource.STARTING, enUS.STARTING },
        { TextResource.ERROR_BATTLENET, enUS.ERROR_BATTLENET },
        { TextResource.ONLINE, enUS.ONLINE },
        { TextResource.OFFLINE, enUS.OFFLINE },
        { TextResource.UPDATING, enUS.UPDATING },
        { TextResource.DOWNLOAD_STATUS, enUS.DOWNLOAD_STATUS },
        { TextResource.REGISTER, enUS.REGISTER },
        { TextResource.ACCOUNT, enUS.ACCOUNT },
        { TextResource.FORUM, enUS.FORUM },
        { TextResource.REALMLISTBTN, enUS.REALMLISTBTN },
        { TextResource.CLEARCACHEBTN, enUS.CLEARCACHEBTN },
        { TextResource.HOTNEWS, enUS.HOTNEWS },
        { TextResource.UPDSTART, enUS.UPDSTART },
        { TextResource.UPDCOMPLETE, enUS.UPDCOMPLETE },
        { TextResource.NEWSBANNERERROR, enUS.NEWSBANNERERROR },
        { TextResource.EXENOTFOUND, enUS.EXENOTFOUND },
        { TextResource.ERRORSTARTINGGAME, enUS.ERRORSTARTINGGAME },
        { TextResource.CACHEOK, enUS.CACHEOK },
        { TextResource.CACHENO, enUS.CACHENO },
        { TextResource.REALMLISTOK, enUS.REALMLISTOK },
        { TextResource.REALMLISTNO, enUS.REALMLISTNO },
        { TextResource.CHARINFOERR, enUS.CHARINFOERR },
        { TextResource.CHARLISTERR, enUS.CHARLISTERR },
        { TextResource.SETTINGOK, enUS.SETTINGOK },
        { TextResource.SETTINGERR, enUS.SETTINGERR },
        { TextResource.TOOLSTATONLINE, enUS.TOOLSTATONLINE },
        { TextResource.TOOLSETTINGS, enUS.TOOLSETTINGS },
        { TextResource.TOOLMINI, enUS.TOOLMINI },
        { TextResource.TOOLCLOSE, enUS.TOOLCLOSE },
        { TextResource.SAVEBTN, enUS.SAVEBTN },
        { TextResource.SETTLABEL1, enUS.SETTLABEL1 },
        { TextResource.SETTLABEL2, enUS.SETTLABEL2 },
        { TextResource.LABELAUTOLOG, enUS.LABELAUTOLOG },
        { TextResource.SETLOGIN, enUS.SETLOGIN },
        { TextResource.SETPASSWORD, enUS.SETPASSWORD },
        { TextResource.SETHEADER, enUS.SETHEADER },
        { TextResource.ENTLOG, enUS.ENTLOG },
        { TextResource.ENTPASS, enUS.ENTPASS },
        { TextResource.TABMENU, enUS.TABMENU },
        { TextResource.TABMENU1, enUS.TABMENU1 },
        { TextResource.TABMENU2, enUS.TABMENU2 },
        { TextResource.CLEARTOOLTIP, enUS.CLEARTOOLTIP },
        { TextResource.CHANGELOC, enUS.CHANGELOC },
        { TextResource.ENTWOWEXE, enUS.ENTWOWEXE },
        { TextResource.BTNCLEAR, enUS.BTNCLEAR },
        { TextResource.EXITBTN, enUS.EXITBTN },
        { TextResource.SEARCHLABEL, enUS.SEARCHLABEL },
        { TextResource.SEARCHCHAR, enUS.SEARCHCHAR },
        { TextResource.HIDELIST, enUS.HIDELIST },
        { TextResource.SHOWLIST, enUS.SHOWLIST },
        { TextResource.DOUBLECLICKCHAR, enUS.DOUBLECLICKCHAR },
        { TextResource.GENINFO, enUS.GENINFO },
        { TextResource.LEVELCHAR, enUS.LEVELCHAR },
        { TextResource.FACTIONCHAR, enUS.FACTIONCHAR },
        { TextResource.CLASSCHAR, enUS.CLASSCHAR },
        { TextResource.PVPCHAR, enUS.PVPCHAR },
        { TextResource.QUESTCHAR, enUS.QUESTCHAR },
        { TextResource.ERRORLOGIN, enUS.ERRORLOGIN },
        { TextResource.NOTLOGORPASS, enUS.NOTLOGORPASS },
        { TextResource.LOGINBTN, enUS.LOGINBTN },
        { TextResource.FORGOTPWD, enUS.FORGOTPWD },
        { TextResource.REMEMBER, enUS.REMEMBER },
        { TextResource.NOTACC, enUS.NOTACC },
        { TextResource.CREATEACC, enUS.CREATEACC },
        { TextResource.ENTERLOGIN, enUS.ENTERLOGIN },
        { TextResource.LOGINEMPTY, enUS.LOGINEMPTY },
        { TextResource.PASSEMPTY, enUS.PASSEMPTY },
        { TextResource.RESETSETT, enUS.RESETSETT },
        { TextResource.CANCELBTN, enUS.CANCELBTN },
        { TextResource.POPUPMSG, enUS.POPUPMSG },
        { TextResource.RESETMSG, enUS.RESETMSG },
        { TextResource.RESETMSGERR, enUS.RESETMSGERR },
        { TextResource.RESTARTBTN, enUS.RESTARTBTN },
        { TextResource.RESTARTLATERBTN, enUS.RESTARTLATERBTN },
        { TextResource.POPUPMSGRESTART, enUS.POPUPMSGRESTART },
        { TextResource.WELCBLOCK, enUS.WELCBLOCK },
        { TextResource.WELCDESCR, enUS.WELCDESCR },
        { TextResource.WELCBTN, enUS.WELCBTN },
        { TextResource.WELCBTNSET, enUS.WELCBTNSET },
        { TextResource.GAMESBTN, enUS.GAMESBTN },
        { TextResource.NEWSBTN, enUS.NEWSBTN },
        { TextResource.ACCMENU, enUS.ACCMENU },
        { TextResource.FORUMMENU, enUS.FORUMMENU },
        { TextResource.SETTMENU, enUS.SETTMENU },
        { TextResource.RELOGMENU, enUS.RELOGMENU },
        { TextResource.EXITMENU, enUS.EXITMENU },
        { TextResource.LANGUAGEMENU, enUS.LANGUAGEMENU },
        { TextResource.GENERALSETLABEL, enUS.GENERALSETLABEL },
        { TextResource.COPYAPP, enUS.COPYAPP },
        { TextResource.ALLREALMS, enUS.ALLREALMS },
        { TextResource.CONFTEXT, enUS.CONFTEXT },
        { TextResource.OPENGAMECONF, enUS.OPENGAMECONF },
        { TextResource.SETTINGSBTN, enUS.SETTINGSBTN },
        { TextResource.SHOPBTN, enUS.SHOPBTN },
        { TextResource.FORUMBTN, enUS.FORUMBTN },
        { TextResource.CHANGEGAMELANG, enUS.CHANGEGAMELANG },
        { TextResource.ERRORLOGINORPASSWORD, enUS.ERRORLOGINORPASSWORD }

        };

            Add(Languages.ptBR, ptBRTextResources);
            Add(Languages.enUS, enUSTextResources);

        }
    }
}

