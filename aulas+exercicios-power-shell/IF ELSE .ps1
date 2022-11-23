Clear-host
#RACUNHO

#[int]$idade = 16;

#SE IDADE é maior o uigual a 18
#C# if($idade >= 18)

#SE(idade é maior ouigual a 18) Então
    #Escreva na tela: "vc é maior de idade!";
#Fim do SE
#if($idade -ge 18)
#{
    #Write-Host "vc é maior de idade!";
#}
#else
#{
    #Write-Host "Vc é menor de idade!";
#}

    #Estrutaras de condição
    #exemplo 01 - if e else
    [int]$idade = Read-Host "Digite a sua idade";
    if($idade -ge 18)
    {
        Write-Host "Voce é maior de idade";
    }
    else
    {
        Write-Host "Voce é menor de idade";   
    }
    Read-Host "Digite uma tecla para continuar";
    Clear-Host

    <#
    Exemplo 02 - else if
    -> menor que 18 - 5% desconto
    -> 18 até 45 - 10% desconto
    -> maior que 45 - 15% desconto
    #>

    if($idade -gt 0 -and $idade -lt 18)
    {
        Write-Host "Desconto de 5%";
    }
    elseif($idade -ge 18 -and $idade -le 45)
    {
        Write-Host "Desconto de 10%";
    }
    elseif($idade -gt 45)
    {
        Write-Host "Desconto de 15%";
    }
    else
    {
        Write-Host "Idade invalida";
    }
    #Exemplo 03 - Operador -or(ou)
    #F8 executa parte exclusiva

    [int]$idade = 17;
    [string]$status = "Estudante";

    if(($status -le 18) -or ($status -eq "Estudante"))
    {
        Write-Host "Parabéns!!! vc é um estudante";
    }
    else
    {
        Write-Host "Estude na ETEC João Berlamino
                    Faça sua inscrição em:
                    https://www.vestibulinhoetec.com.br";
    }

    #Exemplo 04 - Operador and e or juntos
    #Se o (((num1 > num2) e (num2 > num3)) ou ((num2 -- num3)))
    
    [int]$num1 = 8;
    [int]$num2 = 4;
    [int]$num3 = 6;

    if(($num1 -gt $num2 -and $num2 -gt $num3) -or ($num3 -eq $num2))
    {
        Write-Host "Entrou no if";
    }
    else
    {
         Write-Host "Não entrou no if";
    }