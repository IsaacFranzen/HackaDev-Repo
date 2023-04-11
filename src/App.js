import React from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import "./styles/globals.js";


import Home from "./pages/Home";
import Cadastro from "./pages/Cadastro.js";
import Layout from "./components/Layout/Layout";
import TransacaoPage from "./pages/TransacaoPage.js";
import SaldoPage from "./pages/SaldoPage.js";
import LogadoPage from "./pages/LogadoPage.js";

function App() {
  return (
    <>
      <Router>
        <Routes>
          <Route exact path="/" element={<Home />} />
          <Route path="/cadastro" element={<Cadastro />} />
          <Route exact path="/" element={<Layout />} />
          <Route path="/area-logada" element={<LogadoPage/>}/>
          <Route path="/transacoes" element= {<TransacaoPage />} />
          <Route path="/saldo" element= {<SaldoPage />} />
        </Routes>
      </Router>
        
      
    </>
  );
}

export default App;
