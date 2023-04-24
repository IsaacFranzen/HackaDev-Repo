import axios from "axios";

export const api = axios.create({
  baseURL: "https://tecbank-backend.up.railway.app",
  headers: {
    "Content-Type": "application/json",
  },
});

export const createSession = async (numeroConta, senha) => {
  return api.post("/api/login", { numeroConta, senha });
};

export const getUsers = async () => {
  return api.get("/api/clientes");
};
export const getTransacoes = async () => {
  return api.get("/api/transacoes");
};

export const createTransacaoPix = async () => {
  return api.post("/api/transacoes/pix");
};
