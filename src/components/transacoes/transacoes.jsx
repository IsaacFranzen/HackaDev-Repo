import React from 'react';
import styled from "styled-components";

const Table = styled.table`
  width: 100%;
  border-collapse: collapse;
  margin-bottom: 1.5rem;

  th {
    background-color: #7920be;
    color: #fff;
    font-weight: 700;
    padding: 1rem;
    text-align: left;
    border: 1px solid #ddd;
  }

  td {
    padding: 0.75rem;
    border: 1px solid #ddd;
  }

  td:last-child {
    font-weight: 700;
    color: ${({ value }) => value < 0 ? 'red' : '#7920be'};
  }
`;

const transactions = [
  { id: 1, date: '2023-04-09', type: 'Depósito', value: 1000 },
  { id: 2, date: '2023-04-10', type: 'Transferência', value: -500 },
  { id: 3, date: '2023-04-11', type: 'Saque', value: -200 },
  { id: 4, date: '2023-04-11', type: 'Depósito', value: 1500 },
  { id: 5, date: '2023-04-11', type: 'Transferência', value: -1000 },
];

const Transacao = () => {
  return (
    <div style={{ marginTop: "7%"}}>
      <h1>Histórico de Transações</h1>
      <Table>
        <thead>
          <tr>
            <th>Data</th>
            <th>Tipo</th>
            <th>Valor</th>
          </tr>
        </thead>
        <tbody>
          {transactions.map((transaction) => (
            <tr key={transaction.id}>
              <td>{transaction.date}</td>
              <td>{transaction.type}</td>
              <td style={{ color: transaction.value < 0 ? 'red' : 'black' }}>
                {transaction.value.toLocaleString('pt-br', { style: 'currency', currency: 'BRL' })}
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </div>
  );
};

export default Transacao;