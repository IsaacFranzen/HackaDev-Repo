/* eslint-disable react/prop-types */
import React from "react";
import { useForm } from "react-hook-form";
import {
  InputCampo,
  InputDados,
  LabelDados,
  SelectDados,
} from "./StylesAbas-styles";

const TerceiraAba = ({ formData, setFormData }) => {
  const { register, handleSubmit } = useForm();
  const submit = (data) => console.log(data);
  return (
    <div
      style={{
        display: "flex",
        justifyContent: "center",
        height: "58vh",
      }}
    >
      <form onSubmit={handleSubmit(submit)} style={{ width: "90%" }}>
        <div style={{ display: "flex", justifyContent: "space-between" }}>
          <InputCampo style={{ width: "50%" }}>
            <LabelDados>PROFISSAO</LabelDados>
            <InputDados
              type="text"
              name="profissao"
              {...register("profissao")}
              value={formData.profissao}
              onChange={(event) => {
                setFormData({ ...formData, profissao: event.target.value });
              }}
            />
          </InputCampo>
          <InputCampo style={{ width: "49%" }}>
            <LabelDados>NOME DA EMPRESA</LabelDados>
            <InputDados
              type="tel"
              name="nomeEmpresa"
              {...register("nomeEmpresa")}
              value={formData.nomeEmpresa}
              onChange={(event) => {
                setFormData({ ...formData, nomeEmpresa: event.target.value });
              }}
            />
          </InputCampo>
        </div>
        <div style={{ display: "flex", justifyContent: "space-between" }}>
          <InputCampo style={{ width: "40%", marginRight: "10px" }}>
            <LabelDados>RENDA MENSAL</LabelDados>
            <InputDados
              type="text"
              name="rendaMensal"
              {...register("rendaMensal")}
              value={formData.rendaMensal}
              onChange={(event) => {
                setFormData({ ...formData, rendaMensal: event.target.value });
              }}
            />
          </InputCampo>
          <InputCampo style={{ width: "40%", marginRight: "10px" }}>
            <LabelDados>PATRIMONIO</LabelDados>
            <SelectDados
              name="patrimonio"
              {...register("patrimonio")}
              value={formData.patrimonio}
              onChange={(event) => {
                setFormData({ ...formData, patrimonio: event.target.value });
              }}
            >
              <option value="">Selecione..</option>
              <option value="ate15">Até 15.000,00</option>
              <option value="ate35">Até 35.000,00</option>
              <option value="ate100">Até 100.000,00</option>
              <option value="ate150">Até 150.000,00</option>
              <option value="acima150">Acima de 150.000,00</option>
            </SelectDados>
          </InputCampo>
          <InputCampo style={{ width: "40%" }}>
            <LabelDados>TELEFONE COMERCIAL</LabelDados>
            <InputDados
              name="telefoneComercial"
              {...register("telefoneComercial")}
              value={formData.telefoneComercial}
              onChange={(event) => {
                setFormData({
                  ...formData,
                  telefoneComercial: event.target.value,
                });
              }}
            />
          </InputCampo>
        </div>
      </form>
    </div>
  );
};

export default TerceiraAba;
