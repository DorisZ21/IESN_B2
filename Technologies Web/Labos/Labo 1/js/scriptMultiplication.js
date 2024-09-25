function affichagePremierNombre(){
    document.write("<p class='nombre'>" + premierNombre + "</p>");
}

function affichageTableau(){
    document.write("<table>");
    document.write("<tr>");
    document.write("<th>Nombre</th>");
    document.write("<th>Facteur</th>");
    document.write("<th>Résultat</th>");
    document.write("</tr>");    
    for(let facteur = 1; facteur <= 10;facteur++){
            document.write("<tr>");
            document.write("<td>" + premierNombre + "</td>");
            document.write("<td>" + facteur + "</td>");
            document.write("<td>" + facteur * premierNombre + "</td>");
            document.write("</tr>");
    }
    document.write("</table>");
}