Cliente cliente1 = new Cliente(
    "Yuri Alberto",
    "12345678900"
);

Veiculo veiculo1 = new Veiculo(
    "Amarock",
    "FNJ8E20"
);

Locacao Locacao1 = new Locacao(
     cliente1,
     veiculo1,
     new DateOnly(2026, 10, 1),
     5,
     150m
     );

Locacao1.ExibirResumo();

Cliente cliente2 = new Cliente(
    "Hugo Souza",
    "23456789015"
);

Veiculo veiculo2 = new Veiculo(
    "Savero",
    "EJNW34T"
);

Locacao Locacao2 = new Locacao(
     cliente2,
     veiculo2,
     new DateOnly(2026, 10, 1),
     8,
     150m
     );

Locacao2.ExibirResumo();