import React from "react";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import "./styles/globals.js";

import Layout from "./components/Layout/Layout";
import TransacaoPage from "./pages/TransacaoPage.js";
import SaldoPage from "./pages/SaldoPage.js";
import LogadoPage from "./pages/LogadoPage.js";

function App() {
  return (
    <>
      <BrowserRouter>
        <Routes>
          <Route exact path="/" element={<Layout />} />
          <Route path="/about" element={<Layout />} />
          <Route path="/area-logada" element={<LogadoPage/>}/>
          <Route path="/transacoes" element= {<TransacaoPage />} />
          <Route path="/saldo" element= {<SaldoPage />} />
        </Routes>
      </BrowserRouter>
      
    </>
  );
}

export default App;
