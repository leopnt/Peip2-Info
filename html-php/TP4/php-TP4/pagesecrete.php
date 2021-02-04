<html>
    <head>
        <title>Page secrète</title>
    </head>
    <body>
        <?php 
            if($_POST['login'] == 'leolepro' && $_POST['mdp'] == 'yolo') {
                echo "connecté avec succès !";
            }
            else {
                echo 'informations de connexion incorrectes.';
                ?>
                <a href="formulaireMDP.php">réessayer</a>
                <?php
            }
        ?>
    </body>
</html>