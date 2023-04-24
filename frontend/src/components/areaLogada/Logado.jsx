import React, { useContext, useState } from "react";
import MakeTransference from "./../MakeTransference/MakeTransference";
import styled from "styled-components";
import { AuthContext } from "../../contexts/auth";

const LogadoArea = () => {
  const [transferVisible, setTransferVisible] = useState(false);

  const estilo = {
    marginTop: "7%",
    color: "black",
    padding: "20px",
    textAlign: "center",
  };

  const historicoLinkTitle = {
    display: "flex",
    justifyContent: "center",
    alignItems: "center",
    position: "relative",
  };

  const Title = {
    margin: "0 0 15px 0",
  };

  const sectionSaldo = {
    display: "flex",
    flexDirection: "column",
    backgroundColor: "blueviolet",
    borderRadius: "5px",
    color: "whitesmoke",
    width: "60%",
    margin: "0 auto",
    padding: "15px",
  };

  const linkTransfer = {
    height: "max-content",
    marginBottom: "10px",
    width: "max-content",
    padding: "6px 15px",
    border: "0",
    fontSize: "14px",
    backgroundColor: "#2313a4",
    color: "white",
    cursor: "Pointer",
    borderRadius: "2px",
    textDecoration: "none",
  };

  const saldos = {
    display: "flex",
    justifyContent: "space-around",
    flexWrap: "wrap",
  };

  const saldoValue = {
    display: "flex",
    flexDirection: "column",
    margin: "10px",
  };

  const saldoTitle = {
    fontWeight: "normal",
    fontSize: "20px",
    margin: "0",
  };

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
      color: ${({ value }) => (value < 0 ? "red" : "#7920be")};
    }
  `;

  const transactions = [
    { id: 1, date: "2023-04-09", type: "Depósito", value: 1000 },
    { id: 2, date: "2023-04-10", type: "Transferência", value: -500 },
    { id: 3, date: "2023-04-11", type: "Saque", value: -200 },
    { id: 4, date: "2023-04-11", type: "Depósito", value: 1500 },
    { id: 5, date: "2023-04-11", type: "Transferência", value: -1000 },
  ];

  const { logout } = useContext(AuthContext);

  const handleLogout = () => {
    logout();
  };

  return (
    <>
      <div style={estilo}>
        <h2 style={Title}>Olá, Seja bem-vindo</h2>

        <section style={sectionSaldo}>
          <div
            style={{
              display: "flex",
              flexDirection: "row",
              justifyContent: "space-between",
            }}
          >
            <a
              href="#"
              onClick={() => setTransferVisible(true)}
              style={linkTransfer}
            >
              Transferência
            </a>
            <button onClick={handleLogout} style={linkTransfer}>
              Logout
            </button>
          </div>

          <div style={saldos}>
            <div style={saldoValue}>
              <h1 style={saldoTitle}>Saldo conta corrente</h1>

              <h2>R$ 1000.00</h2>
            </div>

            <div style={saldoValue}>
              <h1 style={saldoTitle}>Saldo disponivel para saque</h1>

              <h2>R$ 1000.00</h2>
            </div>
          </div>
        </section>

        <div style={{ marginTop: "7%", padding: "0 100px" }}>
          <div style={historicoLinkTitle}>
            <h2 style={Title}>Histórico de Transações</h2>
          </div>

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
                  <td
                    style={{ color: transaction.value < 0 ? "red" : "black" }}
                  >
                    {transaction.value.toLocaleString("pt-br", {
                      style: "currency",
                      currency: "BRL",
                    })}
                  </td>
                </tr>
              ))}
            </tbody>
          </Table>
        </div>

        {/*
        <p>Clique na opção escolhida para ser redirecionada para a página com as informações desejadas</p>
          <a href="/transacoes" style={linkEstilo}>Transações</a>
          <a href="/saldo" style={linkEstilo}>Saldo</a>
          <a href="#" onClick={() => setTransferVisible(true)} style={linkEstilo}>Transferência</a>
        */}
      </div>

      <MakeTransference
        isOpen={transferVisible}
        setModalClose={() => setTransferVisible(false)}
      />
    </>
  );
};

export default LogadoArea;
