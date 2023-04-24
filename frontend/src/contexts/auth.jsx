/* eslint-disable react/prop-types */
import React, { createContext, useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { api, createSession } from "../services/apis";
export const AuthContext = createContext();

export const AuthProvider = ({ children }) => {
  const navigate = useNavigate();

  const [user, setUser] = useState(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const recoveredUser = localStorage.getItem("user");
    const token = localStorage.getItem("token");

    if (recoveredUser && token) {
      api.defaults.headers.Authorization = `Bearer ${token}`;

      setUser(JSON.parse(recoveredUser));
    }
    setLoading(false);
  }, []);
  const login = async (numeroConta, senha) => {
    const response = await createSession(numeroConta, senha);
    console.log("login", response.data);
    const loggedUser = response.data.cliente;

    const token = response.data.token;
    localStorage.setItem("user", JSON.stringify(loggedUser));
    localStorage.setItem("token", token);

    api.defaults.headers.Authorization = `Bearer ${token}`;
    setUser(loggedUser);
    navigate("/area-logada");
  };
  const logout = () => {
    console.log("logout");
    localStorage.removeItem("user");
    localStorage.removeItem("token");
    api.defaults.headers.Authorization = null;
    setUser(null);
    navigate("/");
  };
  return (
    <AuthContext.Provider
      value={{ authenticated: !!user, user, loading, login, logout }}
    >
      {children}
    </AuthContext.Provider>
  );
};
