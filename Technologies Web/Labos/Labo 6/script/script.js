function minArray(nbs){
    let min = Number.MAX_VALUE;
    nbs.forEach(element => {
        if(element < min){
            min = element;
        }
    });

    return min;
}

function minNumbre(nbs){
    let min = Number.MAX_VALUE;
    Array.of(nbs).forEach(element => {
        if(element < min){
            min = element;
        }
    });

    return min;
}


function min(...nbs){
    if(Array.isArray(nbs[0])) return minArray(nbs[0]);
    if(typeof nbs[0] == "number") return minNumbre(...nbs);
}

function somme(...nbs){
    let sum = 0;
    if(typeof nbs[0] === "function"){
        const funct = nbs[0];
        for(let i = 1; i < nbs.length; i++){
            sum += funct(nbs[i]);
        }    
    }else{
        for(let i = 0; i < nbs.length; i++){
            sum += nbs[i];
        }
    }

    return sum;
}


function plus2(valeur){
    return valeur + 2;
}

function fois3(valeur){
    return valeur * 3;
}

function cube(valeur){
    return valeur ** 3;
}

function app2 (f, x) { return f(f(x)); }


function afficheNFois(s, n=3){
    for(let i = 0; i < n; i++){
        console.log(s);
    }
}

function executeNFois(f,n){
    for(let i = 0; i < n; i++){
        f();
    } 
}

function message() { console.log("Ceci est un message !"); }

function appn(f,n,x){
    for(let i = 0; i < n; i++){
        x = f(x);
    }

    return x;
}

["un","deux","trois","quatre","cinq"].forEach(elem => {
    console.log(elem.length);
});

[1,2,3,4,5,6,7,8,9,10].filter(x => x % 2 == 0);