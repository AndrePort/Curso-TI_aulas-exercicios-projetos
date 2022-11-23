Clear-Host
#Set-ExecutionPolicy -ExecutionPolicy Unrestricted -Scope LocalMachine;
#Set-ExecutionPolicy -ExecutionPolicy Undefined -Scope LocalMachine;

#For | While | Do...While
#For (Laço controlado)
#for(contador;condicao;incremento/$i + 1 ou $i++  [$i += 2] laço de 2 em 2)
#for($i=10; $1 -ge 1; $1--) decremento
Write-Host "----------------- For --------------------";
for($i = 1; $i -le 10; $i++)
{
    Write-Host "Contando: $i";
}
#ENQUANTO(condicao) FAÇA 
#    Alguma coisa...
#FIM do ENQUANTO

Write-Host "-------------- while -------------------";

[int]$i = Read-Host "Digite um numero";
while($i -le 100)
{
    Write-Host "Contando com while até 100: $i";
    $i++;
}
#FAÇA
#Alguma coisa
#ENQUANTO(condicao)

Write-Host "-------------- Do...while ---------------";

$i = 6;
do
{
    Write-Host "Contando com while até 100: $i";
    $i++;
}
while($i -le 5);