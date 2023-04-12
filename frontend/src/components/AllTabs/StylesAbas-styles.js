import styled from "styled-components";

export const InputDados = styled.input`
  width: 100%;
  height: 50px;
  margin: 30px 0;
  border: 1px solid #8c8686;
  border-radius: 5px;
  outline: none;
  font-size: 1em;
  padding: 0 35px 0 5px;
`;
export const SelectDados = styled.select`
  width: 100%;
  height: 50px;
  margin: 30px 0;
  border: 1px solid #8c8686;
  border-radius: 5px;
  outline: none;
  font-size: 1em;
  padding: 0 35px 0 5px;
`;

export const InputCampo = styled.div`
  position: relative;
  width: 100%;
  height: 50px;
  margin: 30px 0;
`;

export const LabelDados = styled.label`
  position: absolute;
  left: 5px;
  top: 40%;
  transform: translateY(-50%);
  font-size: 1em;
  font-weight: 600;
  pointer-events: none;
  transition: 0.5s;
  line-height: 57px;
`;

export const DivCheckbox = styled.div`
  display: flex;
  margin-top: 10px;
  flex-direction: row;
  align-items: center;
  > input {
    width: 30px;
    height: 30px;
  }

  > label {
    margin-right: 8px;
    font-weight: bold;
  }
`;
