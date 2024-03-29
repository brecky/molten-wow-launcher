﻿Module mod_lang
    'english language
    Public Function mainlang_en()
        'main form language
        frm_main.Text = "Molten wow Game Launcher"
        'main label
        frm_main.Label4.Text = "Chose the server from the list and click play world of warcraft..."
        'list servers
        frm_main.list_servers.Columns(0).Text = "Server"
        frm_main.list_servers.Columns(1).Text = "Location"
        frm_main.list_servers.Columns(2).Text = "Reamlist"
        frm_main.list_servers.Columns(3).Text = "Status"
        'buttoms
        frm_main.btn_server_add.Text = "Add server"
        frm_main.btn_server_remove.Text = "Remove server"
        frm_main.btn_selserver.Text = "Set Realmlist"
        frm_main.btn_clearcache.Text = "Clear Cache"
        frm_main.btn_options.Text = "Options"
        frm_main.btn_playwow.Text = "Play World of Warcraft"
        'StatusBar labels
        frm_main.Label1.Text = "Language: "
        frm_main.Label2.Text = "Game Dir: "
        frm_main.Label3.Text = "Latency: "
        'cache messages texts
        frm_main.Label5.Text = "The game's path is invalid. Please check your game directory and try again"
        frm_main.Label6.Text = "The GAME CACHE was already deleted."
        frm_main.Label7.Text = "The GAME CACHE was deleted successfully"
        Return (0)
    End Function
    Public Function addlang_en()
        'add server form language
        frm_addserver.Text = "Game Launcher - Add Server"
        'main labels
        frm_addserver.Label1.Text = "Server Name"
        frm_addserver.Label2.Text = "Server Region"
        frm_addserver.Label3.Text = "Server Realmlist"
        frm_addserver.Label4.Text = "set realmlist:"
        frm_addserver.Label5.Text = "(Example: logon.molten-wow.com)"
        frm_addserver.Label6.Text = "Note: Write only the url in Server Realmlist. You need exclude the 'Set Realmlist'. If you write 'Set Realmlist' in Server realm the launcher can't connect to server."
        'buttoms
        frm_addserver.btn_addserver.Text = "Add Server to list"
        frm_addserver.btn_cancel.Text = "Cancel"
        Return (0)
    End Function
    Public Function optionslang_en()
        'options form language
        frm_options.Text = "Game Launcher Options"
        'main labels
        frm_options.Label1.Text = "Game Dir:"
        frm_options.Label2.Text = "Game Client Language:"
        frm_options.Label3.Text = "Game launcher Language:"
        frm_options.Label4.Text = "When play world of warcraft:"
        frm_options.Label6.Text = "Note: Selecting your game directory, the program searches the file 'wow.exe' in the selected directory." & vbCrLf & "Note2: If you select a language that does not match the game client, the game launcher will not work correctly."
        'buttoms
        frm_options.btn_acept.Text = "Accept"
        frm_options.btn_apply.Text = "Apply Changes"
        frm_options.btn_cancel.Text = "Cancel"
        frm_options.btn_seldir.Text = "Select Dir."
        'directory settings
        frm_options.FolderBrowserDialog1.Description = "Select the Main World of Warcraft Folder where 'wow.exe' is located"
        frm_options.Label5.Text = "The Selected folder '"
        frm_options.Label7.Text = "' does not have world of warcraft installed" & vbCrLf & "Please select a validate path."
        'game client lang
        frm_options.cbx_gamelang.Items.Clear()
        frm_options.cbx_gamelang.Items.Add("English (United States)")
        frm_options.cbx_gamelang.Items.Add("English (Great Britain)")
        frm_options.cbx_gamelang.Items.Add("German")
        frm_options.cbx_gamelang.Items.Add("French")
        frm_options.cbx_gamelang.Items.Add("Spanish(Spain)")
        frm_options.cbx_gamelang.Items.Add("Spanish(Mexico)")
        frm_options.cbx_gamelang.Items.Add("Russian")
        'game launcher lang
        frm_options.cbx_gllang.Items.Clear()
        frm_options.cbx_gllang.Items.Add("English")
        frm_options.cbx_gllang.Items.Add("Español")
        'playing wow options lang
        frm_options.cbx_playwow.Items.Clear()
        frm_options.cbx_playwow.Items.Add("Hide Game launcher")
        frm_options.cbx_playwow.Items.Add("Close Game launcher")
        frm_options.cbx_playwow.Items.Add("Do Nothing")
        Return (0)
    End Function
    'end english languaje
    '
    '==================================================================================================================
    '
    '
    '
    '
    '==================================================================================================================
    '
    'spanish language
    Public Function mainlang_es()
        'main form language
        frm_main.Text = "Molten Wow - Lanzador de Juego"
        'main label
        frm_main.Label4.Text = "Selecciona el servidor de la lista, y cliquea Jugar World of warcraf."
        'list servers
        frm_main.list_servers.Columns(0).Text = "Servidor"
        frm_main.list_servers.Columns(1).Text = "Ubicacion"
        frm_main.list_servers.Columns(2).Text = "Direccion"
        frm_main.list_servers.Columns(3).Text = "Estado"
        'buttoms
        frm_main.btn_server_add.Text = "Agregar Dir."
        frm_main.btn_server_remove.Text = "Remover Dir"
        frm_main.btn_selserver.Text = "Seleccionar"
        frm_main.btn_clearcache.Text = "Borrar Cache"
        frm_main.btn_options.Text = "Opciones"
        frm_main.btn_playwow.Text = "Jugar World of Warcraft"
        'StatusBar labels
        frm_main.Label1.Text = "Idioma: "
        frm_main.Label2.Text = "Directorio: "
        frm_main.Label3.Text = "Latencia: "
        'cache messages texts
        frm_main.Label5.Text = "El directorio de juego es incorrecto, verifica la ubicacion e intentalo nuevamente."
        frm_main.Label6.Text = "El CACHE del juego ya se ha eliminado"
        frm_main.Label7.Text = "El CACHE del juego se limpió correctamente, los archivos fueron eliminados con éxito"
        Return (0)
    End Function
    Public Function addlang_es()
        'add server form language
        frm_addserver.Text = "Agregar Servidor a la lista"
        'main labels
        frm_addserver.Label1.Text = "Serv. Nombre"
        frm_addserver.Label2.Text = "Serv. Region"
        frm_addserver.Label3.Text = "Serv. Realmlist"
        frm_addserver.Label4.Text = "set realmlist:"
        frm_addserver.Label5.Text = "(Ejemplo: logon.molten-wow.com)"
        frm_addserver.Label6.Text = "Nota: Escribe solamente la direccion url del servidor, Debes Excluir 'Set Realmlist'. Si escribes 'Set Realmlist en la direcion el lanzador no logrará conectar al servidor"
        'buttoms
        frm_addserver.btn_addserver.Text = "Agregar Servidor"
        frm_addserver.btn_cancel.Text = "Cancelar"
        Return (0)
    End Function
    Public Function optionslang_es()
        'options form language
        frm_options.Text = "Opciones del Lanzador"
        'main labels
        frm_options.Label1.Text = "Dir. Cliente:"
        frm_options.Label2.Text = "Idioma del juego:"
        frm_options.Label3.Text = "Idioma del Lanzador:"
        frm_options.Label4.Text = "Al iniciar world of warcraft:"
        frm_options.Label6.Text = "Nota: Al seleccionar el directorio del juego el programa va a buscar el archivo llamado 'wow.exe'" & vbCrLf & "Nota2: Si seleccionas un idioma diferente al de tu cliente el programa puede no funcionar correctamente y dar un error."
        'buttoms
        frm_options.btn_acept.Text = "Aceptar"
        frm_options.btn_apply.Text = "Aplicar Cambios"
        frm_options.btn_cancel.Text = "Cancelar"
        frm_options.btn_seldir.Text = "Seleccioar Dir."
        'directory settings
        frm_options.FolderBrowserDialog1.Description = "Selecciona la carpeta donde tienes instalado Word Of Warcraft"
        frm_options.Label5.Text = "La carpeta seleccionada '"
        frm_options.Label7.Text = "' no contiene world of warcraft instalado" & vbCrLf & "Por favor selecciona un directorio correcto"
        'game client lang
        frm_options.cbx_gamelang.Items.Clear()
        frm_options.cbx_gamelang.Items.Add("Inglés (Estados Unidos)")
        frm_options.cbx_gamelang.Items.Add("Inglés (Inglaterra)")
        frm_options.cbx_gamelang.Items.Add("Alemán")
        frm_options.cbx_gamelang.Items.Add("Frances")
        frm_options.cbx_gamelang.Items.Add("Español(España)")
        frm_options.cbx_gamelang.Items.Add("Español(Mexico)")
        frm_options.cbx_gamelang.Items.Add("Ruso")
        'game launcher lang
        frm_options.cbx_gllang.Items.Clear()
        frm_options.cbx_gllang.Items.Add("English")
        frm_options.cbx_gllang.Items.Add("Español")
        'playing wow options lang
        frm_options.cbx_playwow.Items.Clear()
        frm_options.cbx_playwow.Items.Add("Esconder en barra de tareas")
        frm_options.cbx_playwow.Items.Add("Cerrar el programa")
        frm_options.cbx_playwow.Items.Add("No hacer nada")
        Return (0)
    End Function
    'end spanish languaje
End Module
