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
            //伪窗口模式->全屏模式
            main.style.left = 0;
            main.style.width = window.innerWidth - 30 + "px";
            main.style.borderRadius = 0;
            if(window.innerWidth < 800){
                //横布局->纵布局
                ctrl.style.float = "none";
                ctnt.style.float = "none";
                ctrl.style.width = main.offsetWidth - 30 + "px";
                ctnt.style.width = ctrl.style.width;
            }
            else{
                //纵布局->横布局
                ctrl.style.float = "left";
                ctnt.style.float = "right";
                if(ctnt.hidden){
                    ctrl.style.width = main.style.width;
                }
                else{
                    if((main.offsetWidth-30)/3 < 300){
                        ctrl.style.width = "300px";
                    }
                    else{
                        ctrl.style.width = (main.offsetWidth-30)/3 + "px";
                    }
                    ctnt.style.width = main.offsetWidth - 30 - ctrl.offsetWidth + "px";
                }
            }
        }
        else{
            //全屏模式->伪窗口模式
            ctrl.style.float = "left";
            ctnt.style.float = "right";
            main.style.left = window.innerWidth / 2 - main.offsetWidth / 2 + "px";
            main.style.width = "1200px";
            main.style.borderRadius = "5px";
            if(ctnt.hidden){
                ctrl.style.width = main.style.width;
            }
            else{
                if((main.offsetWidth-30)/3 < 300){
                    ctrl.style.width = "300px";
                }
                else{
                    ctrl.style.width = (main.offsetWidth-30)/3 + "px";
                }
                ctnt.style.width = main.offsetWidth - 30 - ctrl.offsetWidth + "px";
            }
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
//fileget
if(!(window.File && window.FileList && window.FileReader && window.Blob)){
    alert("您的浏览器不支持LPlayer。\r\nLPlayer即将退出。");
    window.history.go(-1);
}
function startOpenFile(){
    document.getElementById("file").click();
}
function pasteurl(){
    var ev = new KeyboardEvent("keyup",{ctrlKey:true});
    var ev2 = new KeyboardEvent("keyup",{key:"v"});
    var musicurl = document.getElementById("musicurl");
    musicurl.focus();
    console.log(musicurl.dispatchEvent(ev));
    console.log(musicurl.dispatchEvent(ev2));
}
function fileRead(){
    document.getElementById("main").focus();
    var fpicker = document.getElementById("file");
    var file = fpicker.files[0];
    if(file == null){
        return;
    }
    var p = document.getElementById("player");
    p.src = URL.createObjectURL(file);
    var date = new Date();
    var time = "[" + date.getTime()+ "]";
    console.log(time + " start to play " + file.name + " at " + URL.createObjectURL(file));
    p.play();
    playUI(true);
}
//onplay
function playUI(isstart){
    if(isstart){
        ctnt.hidden = false;
        resize(false);
    }
}