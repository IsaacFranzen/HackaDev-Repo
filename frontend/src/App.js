/* eslint-disable react/prop-types */
import React, { useContext } from "react";
import {
  BrowserRouter as Router,
  Route,
  Routes,
  Navigate,
} from "react-router-dom";
import "./styles/globals.js";

import Home from "./pages/Home";
import Cadastro from "./pages/Cadastro.js";
import TransacaoPage from "./pages/TransacaoPage.js";
import LogadoPage from "./pages/LogadoPage.js";
import { AuthProvider, AuthContext } from "./contexts/auth.jsx";
function App() {
  const Private = ({ children }) => {
    const { authenticated, loading } = useContext(AuthContext);

    if (loading) {
      return <div className="loading">Carregando...</div>;
    }
    if (!authenticated) {
      return <Navigate to="/" />;
    }
    return children;
  };
  return (
    <>
      <Router>
        <AuthProvider>
          <Routes>
            <Route exact path="/" element={<Home />} />
            <Route exact path="/cadastro" element={<Cadastro />} />
            <Route
              exact
              path="/area-logada"
              element={
                <Private>
                  <LogadoPage />
                </Private>
              }
            />
            <Route
              exact
              path="/transacoes"
              element={
                <Private>
                  <TransacaoPage />
                </Private>
              }
            />
          </Routes>
        </AuthProvider>
      </Router>
    </>
  );
}

export default App;
