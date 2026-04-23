<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" indent="yes" encoding="utf-8"/>
  <xsl:key name="emp" match="item"
           use="concat(@name, '|', @surname)"/>
  <xsl:template match="/">
    <Employees>
      <xsl:for-each select="//item[
        generate-id() = generate-id(
          key('emp', concat(@name, '|', @surname))[1]
        )
      ]">
        <xsl:sort select="@name"/>
        <xsl:sort select="@surname"/>
        <Employee name="{@name}" surname="{@surname}">
          <xsl:for-each select="key('emp', concat(@name, '|', @surname))">
            <salary amount="{@amount}" mount="{@mount}"/>
          </xsl:for-each>
        </Employee>
      </xsl:for-each>
    </Employees>
  </xsl:template>
</xsl:stylesheet>