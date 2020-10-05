%设置字符集以兼容中文目录%
REM
chcp 65001

%设置你的游戏目录，到YuanShen.exe的目录%
set gameSrc=D:\Game\原神\Genshin Impact\Genshin Impact Game\

%输出一个空行到屏蔽控制文件%
echo= > "%gameSrc%YuanShen_Data\Persistent\AssetBundles\blocks\00\29342328.blk"

powershell.exe -command "start \"%gameSrc%YuanShen.exe\""

%或许有些冗余，因为就算不使用luncher启动游戏，游戏依旧会在有新版本时更新屏蔽控制文件并读取入内存%
timeout /t 180

echo= > "%gameSrc%YuanShen_Data\Persistent\AssetBundles\blocks\00\29342328.blk"

%debug用，可以在成功启动之后删除%
pause