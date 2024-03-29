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
var lrc;
var cover;
var musicname = "";
var artist = "";
var album = "";
var track = "";
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
                document.body.style.overflow = "auto";
                ctnt.style.marginTop = "50px";
            }
            else{
                //纵布局->横布局
                ctrl.style.float = "left";
                ctnt.style.float = "right";
                document.body.style.overflow = "hidden";
                document.body.scrollTop = 0;
                document.documentElement.scrollTop = 0;
                ctnt.style.marginTop = "0";
                if(ctnt.hidden){
                    ctrl.style.width = main.style.width;
                }
                else{
                    if((main.offsetWidth-30)/3 < 200){
                        ctrl.style.width = "200px";
                    }
                    else{
                        ctrl.style.width = (main.offsetWidth-30)/3 + "px";
                    }
                    ctnt.style.width = main.offsetWidth - 31 - ctrl.offsetWidth + "px";
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
            document.body.style.overflow = "hidden";
            document.body.scrollTop = 0;
            document.documentElement.scrollTop = 0;
            ctnt.style.marginTop = "0";
            if(ctnt.hidden){
                ctrl.style.width = main.style.width;
            }
            else{
                if((main.offsetWidth-30)/3 < 200){
                    ctrl.style.width = "200px";
                }
                else{
                    ctrl.style.width = (main.offsetWidth-30)/3 + "px";
                }
                ctnt.style.width = main.offsetWidth - 31 - ctrl.offsetWidth + "px";
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
    var musicurl = document.getElementById("musicurl").value;
    if(musicurl != ""){//任意链接
        if(musicurl.search(/^https?:\/\/.*..*\/.*\.(mp3|flac|ogg|wav|m4a)$/) != -1){
            document.getElementById("musicurl").value = "";
            fileRead(musicurl);
        }
        else if(musicurl.search(/^[1-9]\d*n$/) != -1){//网易云通用API
            document.getElementById("musicurl").value = "";
            fileRead("https://music.163.com/song/media/outer/url?id=" + musicurl.replace("n","") + ".mp3");
        }
        else if(musicurl.search(/^[1-9]\d*k$/) != -1){//酷我通用API
            document.getElementById("musicurl").value = "";
            fileRead("https://www.kuwo.cn/api/v1/www/music/playUrl?mid=" + musicurl.replace("k",""));
        }
        else if(musicurl.search(/^[0-9a-f]*g$/) != -1){//酷狗通用API
            document.getElementById("musicurl").value = "";
            fileRead("https://wwwapi.kugou.com/yy/index.php?r=play/getdata&hash=" + musicurl.replace("g",""));
        }
        else{
            if(!confirm("输入的歌曲链接不符合格式。\r\n1.可能是没有http或https。\r\n2.可能是使用了不支持的文件格式。\r\n仅支持mp3、flac、ogg、wav、m4a文件。\r\n单击“取消”以清空，“确定”以手动修改链接。")){
                document.getElementById("musicurl").value = "";
            }
        }
    }
    else{
        document.getElementById("file").click();
    }
}
function fileRead(url){
    var p = document.getElementById("player");
    if(url != null){
        p.src = url;
        p.play();
        jsmediaRead(url);
        playUI(true);
    }
    else{
        document.getElementById("main").focus();
        var fpicker = document.getElementById("file");
        var file = fpicker.files[0];
        if(file == null){
            return;
        }
        p.src = "";
        p.src = URL.createObjectURL(file);
        fpicker.files[0] = null;
        p.play();
        jsmediaRead(file);
        playUI(true);
    }
}
function jsmediaRead(obj){
    new window.jsmediatags.Reader(obj).read({
        onSuccess:function(tag){
            console.log(tag);
            artist = tag.tags.artist;
            cover = tag.tags.picture.data;
            musicname = tag.tags.title;
            album = tag.tags.album;
            document.title = artist + " - " + musicname;
            if(tag.tags.lyrics.lyrics != null){
                lyrics = tag.tags.lyrics.lyrics;
                ctnt.innerText = lyrics;
            }
        },
        onError:function(err){
            console.log(err.type,err.info);
        }
    });
}
//onplay
var player = document.getElementById("player");
function playUI(isstart){
    if(isstart){
        ctnt.hidden = false;
        resize(false);
    }
}
/*player.addEventListener("play",function(){

});*/
//tips
function musicurlTips(){
    alert("粘贴歌曲链接，包括http(s)://。\r\n————特殊用法————\r\n网易云音乐：输入歌曲ID，然后在末尾加上n，即可解析歌曲。\r\n酷我音乐：输入歌曲ID，然后在末尾加上w，即可解析歌曲。\r\n酷狗音乐：输入歌曲hash，然后在末尾加上g，即可解析歌曲。");
}
function lrcurlTips(){
    alert("");
}
function about(){
    var title = document.getElementById("title");
    if(title.innerText == "LPlayer"){
        title.innerHTML = "<span class='rainbow'>LPlayer</span> - Made By <a href='https://ljm.im' style='color:#5c6be0;text-decoration:none'>LJM12914</a> With ❤ To Music."
    }
    else{
        title.innerText = "LPlayer";
    }
}