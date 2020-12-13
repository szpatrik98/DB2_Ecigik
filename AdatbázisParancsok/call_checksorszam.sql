set serveroutput on;
declare 
    v_call_sorszam int;
    v_sorszam ecigik.sorszam%type := '123654';
begin
v_call_sorszam := sf_check_sorszam(v_sorszam);
    
    IF v_call_sorszam = 1 THEN
        DBMS_OUTPUT.PUT_LINE('Az alábbi sorszam helyes: '||v_sorszam);
    ELSE 
        DBMS_OUTPUT.PUT_LINE('Az alábbi sorszam helytelen: '||v_sorszam);    
    END IF;
END;