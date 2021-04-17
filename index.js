function togglelrc(){
    document.getElementById("lrcurl").hidden = !document.getElementById("lrcurl").hidden;
}
const mobile = new Array("Android","iPhone","SymbianOS","Windows Phone","iPad","iPod");
var ispc = true;
for(var i = 0; i < mobile.length; i++){
    if(navigator.userAgent.indexOf(mobile[i]) > 0){
        ispc = false;
        break;
    }
}
var main = document.getElementById("main");
var ctrl = document.getElementById("controlbox");
var ctnt = document.getElementById("contentbox");
function resize(show){
    if(ispc){
        if(window.innerWidth < 1230){
            main.style.left = 0;
            main.style.width = window.innerWidth - 30 + "px";
            main.style.borderRadius = 0;
            if(window.innerWidth < 800){
                ctrl.style.float = "none";
                ctnt.style.float = "none";
            }
            else{
                ctrl.style.float = "left";
                ctnt.style.float = "right";
            }
        }
        else{
            ctrl.style.float = "left";
            ctnt.style.float = "right";
            main.style.left = window.innerWidth / 2 - main.offsetWidth / 2 + "px";
            main.style.width = "1200px";
            main.style.borderRadius = "5px";
        }
    }
    else{

    }
    if(show){
        main.style.opacity = 1;
    }
}
resize(true);
window.addEventListener("resize",function(){
    resize(false);
    resize(false);
});
//onload - file
function file(){
    var fpicker = document.createElement("input");
    fpicker.type = "file";
    fpicker.accept = ".mp3,.ogg,.flac,.wav";
    fpicker.click();
}