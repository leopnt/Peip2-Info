<?php
    session_start();
    echo $_SESSION['message'];
?>

<html>
    <head>
        <title>Modifier mot de passe</title>
    </head>

    <body>
        <form action="traitement.php" method="post">
            <p>Ancien mot de passe 
                <input type="password" name="ancienMDP">
            </p>
            <p>Nouveau mot de passe 
                <input type="password" name="nouveauMDP">
            </p>
            <p>Confirmer mot de passe 
                <input type="password" name="confirmMDP">
            </p>
            <input type="submit" value="confirmer">
        </form>
    </body>
</html>