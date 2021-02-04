<html>
    <head>
        <title>Formulaire</title>
    </head>
    <body>
        <form action="traitement.php" method="post">
            <p>Nom* <input type="text" name="nom" required="required"></p>
            <p>Prénom* <input type="text" name="prenom" required="required"></p>
            <p>Mot de passe* <input type="password" name="mdp" required="required"></p>
            <p>Age <input type="text" name="age"></p>
            <p>Ajouter des commentaires <input type="text" name="commentaire"></p>
            <p>Email* <input type="text" name="email"></p>
            <p><input type="submit" value="s'enregister" required="required"></p>
        </form>
    </body>
</html>