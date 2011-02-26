Module mod_lang
    'english language
    Public Function mainlang_en()
        'main form language
        frm_main.Text = "Molten wow Game Launcher"
        'main label
        frm_main.Label4.Text = "Chose the server from the list and click connect..."
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
        'add server form language
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
        Return (0)
    End Function
    'end english languaje
    '-------------------------------------------------------------------------------------------------------
    'spanish language
    Public Function mainlang_es()
        'main form language
        frm_main.Text = "Molten Wow - Lanzador de Juego"
        'main label
        frm_main.Label4.Text = "Selecciona el servidor de la lista, y cliquea conectar."
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
        'add server form language
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
        Return (0)
    End Function
    'end english languaje
End Module
