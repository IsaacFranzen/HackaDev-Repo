import React, { useState, useEffect } from 'react';
import { SaldoContainer, SaldoInfo} from "./saldo-style";

const Saldo = () => {
  const [dadosTransacoes, setDadosTransacoes] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      const result = await fetch("https://tecbank_backend.ndre.dev/api/transactions");
      const data = await result.json();
      setDadosTransacoes(data);
    }
    fetchData();
  }, []);

  return (
    <SaldoContainer>
    <div>
      <h2>Saldo</h2>
      <SaldoInfo>
        <p>Saldo atual: R$ {dadosTransacoes[0].amount}</p>
        <p>Saldo disponível para saque: R$ {dadosTransacoes[0].amount}</p>
        <p>Taxa de juros: 2%</p>
        </SaldoInfo>
    </div>
    </SaldoContainer>
  );
}

export default Saldo;