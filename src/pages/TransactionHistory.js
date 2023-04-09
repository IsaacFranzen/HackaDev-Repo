import React, { useState, useEffect } from "react";
import "TransactionHistory.html";
import "TransactionHistory.css";

const TransactionHistory = () => {
  const [transactions, setTransactions] = useState([]);

  useEffect(() => {
    fetch("https://localhost:3001/transactions")
      .then((response) => response.json())
      .then((data) => setTransactions(data));
  }, []);

  return (
    <div className="transictions">
      {transactions.map(transaction => (
        <p key={transaction.id}>{transaction.description}: R$ {transaction.amount}</p>
      ))}
    </div>
  );
};

export default TransactionHistory;

