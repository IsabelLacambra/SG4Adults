# SG4Adults
Serious games for adults
Assets Folder
    Fonts → We have used Dimbo Regular font.
Materials
    Materials → Some of the colors used.
    Sprites → They are divided depending when we use them.
Prephabs
Scenes
Scripts
Menu 
    BotonCredits → Change the scene if we click button “Credits”
    BotonPlay → Change the scene if we click button “Play”
    Parte 1 Juego
            ChangeColorOnMouseOver → Change the sprite of the hexagons if we pass with the mouse over it.
            Dado → Controls the dice
            Dado2 → Controls the button Play, here we SetActive() the GameObject2 wich controls the quiz.
            equipo0x → it controls the movement of the tabs.
            FichasColores → change the color of the tile, when a team block this tile.
            ListaCeldas → In this class we declare all the cells.
            OrganizadorEquipos → Control the turns of the teams.
            UltimaVezClicado → Last time Clicked.
            Puntuaciones → Write the score of each team.
    Parte 2 Juego 
            Database → We access to the xml file 
            Preguntas respuestas
                    ButtonX → See if the answer selected is the correct (quiz)
                    ClsRespX → Print the answers on the screen
                    Correct → See if the answer selected is the correct (master decide)
                   Pregunta → Print the question on the screen
                   SolucionTxt → Print the solution
                    Wrong →  See if the answer selected is wrong (master decide)
           PuntosEquipos → control the score
           Timer → Controls the timer of each question
    ApearQuestion → when the count down is finished, we show on screen the question
    CountDownTimer → initial count down
    DisapearQuestion → disable the buttons once we have selected the answer
    Solucioncontrolador → We show the solution on screen 
