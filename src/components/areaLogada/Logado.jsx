import React from 'react';

const LogadoArea = () => {

    const estilo = {
        marginTop: "7%",
        color: 'black',
        padding: '20px',
        textAlign: 'center'
      };
    
      const linkEstilo = {
        color: '#7920be',
        backgroundColor:'white',
        textDecoration: 'none',
        fontWeight: 'bold',
        marginLeft: '10px',
        border: 'solid 2px white',
        
      };
  return (
    <div style={estilo}>
      <h2>Bem-vindo, Fulano !</h2>
      <p>Clique na opção escolhida para ser redirecionada para a página com as informações desejadas</p>
      <a href="/transacoes" style={linkEstilo}>Transações</a>
      <a href="/saldo" style={linkEstilo}>Saldo</a>
      <a style={linkEstilo}>Transferência</a>
    </div>
  );
};

export default LogadoArea;