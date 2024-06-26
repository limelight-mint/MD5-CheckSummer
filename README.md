# MD5-CheckSummer

<img width=200 height=300 src=https://github.com/prime-lime/MD5-CheckSummer/blob/main/examples/1.png> <img width=200 height=300 src=https://github.com/prime-lime/MD5-CheckSummer/blob/main/examples/2.png>
<img width=200 height=300 src=https://github.com/prime-lime/MD5-CheckSummer/blob/main/examples/3.png>


</details>


<details>
<summary>English</summary>
[Win App] [Lightweight] Small application to get total checksum of all files in folder (and sub-folders inside) and write it in 1 .txt file with custom separator and filename ie [ filepath | hashsum ], can be used to compare 2 hashsum files, just click Compare 2 hashes and paste your 2 files, set 2 separators for each file (for example : or ♡♡♡♡ like we did in the example) and it will parse it. Thats all, have a good day.

Output after pressing Start Encoding:
---

![image](https://github.com/MentallyStable4sure/MD5-Hasher/assets/62771181/4f44689b-cab9-46a6-b69d-dc83be82d890)

![hashes.txt](/examples/hashes.txt)

```
Debug\net7.0-windows\MS4S-MD5Hasher.deps.json ♡♡♡♡ 9f1f8f8cc572e7b056abc3db1cfa1993
Debug\net7.0-windows\MS4S-MD5Hasher.dll ♡♡♡♡ 76dd1522670acad0b25666e61c92ce05
Debug\net7.0-windows\MS4S-MD5Hasher.exe ♡♡♡♡ cbef7a037e09bf4cf3ed55884ece176f
Debug\net7.0-windows\MS4S-MD5Hasher.pdb ♡♡♡♡ 348ab00cc619322a42b6f328b7be4e79
Debug\net7.0-windows\MS4S-MD5Hasher.runtimeconfig.json ♡♡♡♡ d8ae75ee64991f91ddf5fa2c72adcc7c
Release\net7.0-windows\MS4S-MD5Hasher.deps.json ♡♡♡♡ 9f1f8f8cc572e7b056abc3db1cfa1993
Release\net7.0-windows\MS4S-MD5Hasher.dll ♡♡♡♡ a0ec24fb15711e10612893ced6661788
Release\net7.0-windows\MS4S-MD5Hasher.exe ♡♡♡♡ cbef7a037e09bf4cf3ed55884ece176f
Release\net7.0-windows\MS4S-MD5Hasher.pdb ♡♡♡♡ 48979158d96c2d68cad8f36ec30915d8
Release\net7.0-windows\MS4S-MD5Hasher.runtimeconfig.json ♡♡♡♡ cc164c1b948924c198019ea9b728e06e
Release\net7.0-windows\totalhashes.txt ♡♡♡♡ 837c3dc87f8b47074c5eedfaeae96902
```
</details>

<details>
<summary>Russian</summary>
[Виндоус Приложение] [Легковесная аппка] Маленькое приложение чтобы создать текстовый документ со всеми хеш-суммами в виде [ ФАЙЛ (ваш разьеденитель) ХЕШ ], позволяет сделать все это с настраиваемым разделителем и заходит в подпапки внутри директории. Так же можно использовать как сравнения на 2 хешсуммы, просто выберите в начале сравнение - укажите 2 файла, укажите их сепараторы (например в нашем примере были указаны сердечки  ♡♡♡♡ , но если вы используете другой файл то конечно нужно узнать какой там разделить, по умолчанию это : - двоеточие) и нажмите на Start Comparing. Вот и все, приятного пользования.

Вот что получается на выходе после того как мы выбрали папку:
---

![image](https://github.com/MentallyStable4sure/MD5-Hasher/assets/62771181/4f44689b-cab9-46a6-b69d-dc83be82d890)

![hashes.txt](/examples/hashes.txt)

```
Debug\net7.0-windows\MS4S-MD5Hasher.deps.json ♡♡♡♡ 9f1f8f8cc572e7b056abc3db1cfa1993
Debug\net7.0-windows\MS4S-MD5Hasher.dll ♡♡♡♡ 76dd1522670acad0b25666e61c92ce05
Debug\net7.0-windows\MS4S-MD5Hasher.exe ♡♡♡♡ cbef7a037e09bf4cf3ed55884ece176f
Debug\net7.0-windows\MS4S-MD5Hasher.pdb ♡♡♡♡ 348ab00cc619322a42b6f328b7be4e79
Debug\net7.0-windows\MS4S-MD5Hasher.runtimeconfig.json ♡♡♡♡ d8ae75ee64991f91ddf5fa2c72adcc7c
Release\net7.0-windows\MS4S-MD5Hasher.deps.json ♡♡♡♡ 9f1f8f8cc572e7b056abc3db1cfa1993
Release\net7.0-windows\MS4S-MD5Hasher.dll ♡♡♡♡ a0ec24fb15711e10612893ced6661788
Release\net7.0-windows\MS4S-MD5Hasher.exe ♡♡♡♡ cbef7a037e09bf4cf3ed55884ece176f
Release\net7.0-windows\MS4S-MD5Hasher.pdb ♡♡♡♡ 48979158d96c2d68cad8f36ec30915d8
Release\net7.0-windows\MS4S-MD5Hasher.runtimeconfig.json ♡♡♡♡ cc164c1b948924c198019ea9b728e06e
Release\net7.0-windows\totalhashes.txt ♡♡♡♡ 837c3dc87f8b47074c5eedfaeae96902
```
</details>

<details>
<summary>TODO</summary>

### What is planned and what is done already

- ✅ Arguments-friendly (to launch app without UI and set arguments like --compare [path] or --compute [path]) [<a href=https://github.com/MentallyStable4sure/MS4SArgLiteHasher>done</a>]
- ✅ Compare method as additional functionality
- ✅ Checksum from directory for all the files inside folder and subfolder divided by separator ie [Path | Hash]
- ✅ Themes (idk why tho)
- ✅ Custom filenames and separators without limits

</details>
