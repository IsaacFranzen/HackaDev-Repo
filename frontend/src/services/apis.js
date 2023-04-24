import axios from "axios";

export const api = axios.create({
  baseURL: "https://tecbank-backend.up.railway.app",
});

export const createSession = async (numeroConta, senha) => {
  return api.post("/api/login", { numeroConta, senha });
};

export const getUsers = async () => {
  return api.get("/api/clientes");
};
