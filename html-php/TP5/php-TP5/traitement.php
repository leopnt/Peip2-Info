<?php
    session_start();

    //le message transmis au formulaire de changement
    //de mot passe si quelque chose est incorrecte
    $_SESSION['message'] = "";

    //prend les infos depuis formulaire.php
    if(isset($_POST['nom'])) {
        $_SESSION['nom'] = $_POST['nom'];
        $_SESSION['prenom'] = $_POST['prenom'];
        $_SESSION['mdp'] = $_POST['mdp'];
        $_SESSION['age'] = $_POST['age'];
        $_SESSION['commentaire'] = $_POST['commentaire'];
        $_SESSION['email'] = $_POST['email'];
    }

    //prend les infos depuis motdepasse.php
    if(isset($_POST['ancienMDP'])) {
        if($_POST['ancienMDP'] == $_SESSION['mdp']) {
            if($_POST['nouveauMDP'] == $_POST['confirmMDP']) {
                $_SESSION['mdp'] = $_POST['nouveauMDP'];
            }
            else {
                $_SESSION['message'] = "le mot de passe de confirmation ne correspond pas";
                header('Location: motdepasse.php');
                exit();
            }
        }
        else {
            $_SESSION['message'] = "l'ancien mot de passe ne correspond pas";
            header('Location: motdepasse.php');
            exit;
        }
    }
?>

<html>
    <head>
        <title>Bienvenue</title>
    </head>
    <body>
        <p>Bonjour <?php echo $_SESSION['prenom'] . ' ' . $_SESSION['nom'];?></p>

        <p>Mot de passe: <?php echo $_SESSION['mdp']; ?></p>
        <form action="motdepasse.php" method="post">
            <p><input type="submit" value="modifier mot de passe"></p>
        </form>
    </body>
</html>