﻿namespace loja_api.Mapper.Cupom;

public class CupomUpdateDTO
{
    public string Name { get; set; }

    public int Quantity { get; set; }

    public DateTime ExpirationDate { get; set; }

    public int UpdatebyId { get; set; }

    public DateTime UpdateDate { get; set; }
}
